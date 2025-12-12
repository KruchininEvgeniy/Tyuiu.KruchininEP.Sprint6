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
            string path = "1";

            var res = ds.CollectTextFromFile(path);
            string wait = "1";
            Assert.AreEqual(wait, res);
        }

    }
}