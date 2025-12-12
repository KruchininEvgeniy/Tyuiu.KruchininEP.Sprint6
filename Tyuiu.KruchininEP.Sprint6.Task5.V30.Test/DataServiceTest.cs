using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KruchininEP.Sprint6.Task5.V30.Lib;
using System.IO;

namespace Tyuiu.NovikovD.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint6\Tyuiu.KruchininEP.Sprint6.Task5.V30.Test\bin\Debug\net8.0InPutFileTask5V30.txt";

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 5 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}