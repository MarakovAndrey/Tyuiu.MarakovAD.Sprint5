using Tyuiu.MarakovAD.Sprint5.Task5.V20.Lib;
namespace Tyuiu.MarakovAD.Sprint5.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "С:/DataSprint5/InPutDataFileTask5V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
