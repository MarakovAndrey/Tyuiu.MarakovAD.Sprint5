using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarakovAD.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string Savepath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V4.txt");
            FileInfo fileInfo = new FileInfo(Savepath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(Savepath);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path)) {
                string line;
                string CyrillicChars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                while ((line = reader.ReadLine()) != null) {
                    for (int i = 0; i < line.Length; i++) {
                        bool flag = true;
                        foreach (char c in CyrillicChars) {
                            if (line[i] == c)
                            {
                                strLine += '#';
                                flag = false;
                            }
                        }
                        if (flag) {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(Savepath, strLine + Environment.NewLine);
                }
            }
            return Savepath;
        }
    }
}
