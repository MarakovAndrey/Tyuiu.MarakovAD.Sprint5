using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double res = Math.Round(2.12*Math.Pow(x,3) + 1.05 * Math.Pow(x,2) + 4.1 * x * 2, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8)) { 
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
