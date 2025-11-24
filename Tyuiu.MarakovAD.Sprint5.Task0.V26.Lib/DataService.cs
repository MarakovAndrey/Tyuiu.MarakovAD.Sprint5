using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.Metadata.Ecma335;
namespace Tyuiu.MarakovAD.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = Math.Round(0.7 * Math.Pow(x,3) + 1.52 * Math.Pow(x,2),3);
            File.WriteAllText(path, res.ToString());
            return path;
        }
    }
}
