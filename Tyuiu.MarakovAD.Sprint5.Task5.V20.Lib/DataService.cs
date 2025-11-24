using System;
using System.Runtime.Intrinsics.X86;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double rndAv = 0;
            string filecontent = File.ReadAllText(path);
            var numbers = filecontent.Split(new char[] { ' ' });
            List<int> validIntegers = new List<int>();
            foreach (var numStr in numbers) {
                if (int.TryParse(numStr, out int number)) {
                    if (number >= -10 && number <= 10) {
                        validIntegers.Add(number);
                    }
                }
            }
            if (validIntegers.Count > 0) {
                double average = validIntegers.Average();
                rndAv = Math.Round(average, 3);
            }
            return rndAv;
        }
    }
}
