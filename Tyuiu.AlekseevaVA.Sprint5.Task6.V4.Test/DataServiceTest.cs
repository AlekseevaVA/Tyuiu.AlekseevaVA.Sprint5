using System.IO;

using Tyuiu.AlekseevaVA.Sprint5.Task6.V4.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask6V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);

        }
    }
}
