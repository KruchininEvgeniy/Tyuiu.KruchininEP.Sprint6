using Tyuiu.KruchininEP.Sprint6.Task6.V8.Lib;
namespace Tyuiu.KruchininEP.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V8.txt";

            var res = ds.CollectTextFromFile(path);
            string wait = "RizdogMOZpCb GqzgGQOdWpd ztMvvn";
            Assert.AreEqual(wait, res);
        }

    }
}