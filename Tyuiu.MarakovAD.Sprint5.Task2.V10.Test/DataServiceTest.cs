using Tyuiu.MarakovAD.Sprint5.Task2.V10.Lib;
namespace Tyuiu.MarakovAD.Sprint5.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 4, 3, -3 }, { -5, -6, -3 }, { -7, -9, -9 } };
            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
