using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((1/Math.Cos(-1.39)) + Math.Pow(-1.39, 3), 3);
            return res;
        }
    }
}
