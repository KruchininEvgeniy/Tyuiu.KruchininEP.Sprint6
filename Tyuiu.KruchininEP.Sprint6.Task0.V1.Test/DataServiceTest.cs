using Tyuiu.KruchininEP.Sprint6.Task0.V1.Lib;

namespace Tyuiu.NovikovDS.Sprint6.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new();
            Assert.AreEqual(0.2, ds.Calculate(2));
        }
    }
}