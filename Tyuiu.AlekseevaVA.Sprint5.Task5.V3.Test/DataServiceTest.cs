using System.IO;

using Tyuiu.AlekseevaVA.Sprint5.Task5.V3.Lib;


namespace Tyuiu.AlekseevaVA.Sprint5.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask5V3.txt.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);


        }
    }
}
