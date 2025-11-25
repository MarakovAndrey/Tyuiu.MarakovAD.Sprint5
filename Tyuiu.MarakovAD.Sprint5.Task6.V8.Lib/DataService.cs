using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            string fileContent = File.ReadAllText(path);
            var words = fileContent.Split(' ');
            foreach (var word in words) {
                if (word.Length == 2) {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
