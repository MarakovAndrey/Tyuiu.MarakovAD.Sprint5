using Tyuiu.MarakovAD.Sprint5.Task6.V8.Lib;
namespace Tyuiu.MarakovAD.Sprint5.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "С:/DataSprint5/InPutDataFileTask6V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = "С:/DataSprint5/InPutDataFileTask6V8.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
