using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) { 
                File.Delete(path);
            }
            double Res;
            string StrRes;
            for (int x = startValue; x <= stopValue; x++) {
                Res = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x,2);
                StrRes = Convert.ToString(Res);

                if (x != stopValue)
                {
                    File.AppendAllText(path, StrRes + Environment.NewLine);
                }
                else {
                    File.AppendAllText(path, StrRes);
                }
            }
            return path;
        }
    }
}
