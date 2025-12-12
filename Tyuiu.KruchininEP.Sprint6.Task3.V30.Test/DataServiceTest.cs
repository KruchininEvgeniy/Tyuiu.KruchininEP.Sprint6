using Tyuiu.KruchininEP.Sprint6.Task3.V30.Lib;
namespace Tyuiu.KruchininEP.Sprint6.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = { { 1, 2, 3, 4, 5 },
                            { 2, 3, 4, 5, 6 },
                            { 3, 4, 5, 6, 7 },
                            { 4, 5, 6, 7, 8 },
                            { 5, 6, 7, 8, 9 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 1, 2, 3, 4, 5 },
                            { 2, 3, 4, 5, 6 },
                            { 3, 4, 5, 6, 7 },
                            { 4, 5, 6, 7, 8 },
                            { 5, 0, 7, 0, 9 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}