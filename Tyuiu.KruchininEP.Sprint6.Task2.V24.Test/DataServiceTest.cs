using Tyuiu.KruchininEP.Sprint6.Task2.V24.Lib;
namespace Tyuiu.KruchininEP.Sprint6.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[] { -8.86, -7.19, -6.14, -4.76, -2.33, 1, 4.38, 0, 6.13, 7.07, 8.61 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}