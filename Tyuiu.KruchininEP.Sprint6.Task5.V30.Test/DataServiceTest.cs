using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KruchininEP.Sprint6.Task5.V30.Lib;
using System.IO;

namespace Tyuiu.KruchininEP.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V30.txt";

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 5 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}