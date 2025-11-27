using System.IO;

using Tyuiu.AlekseevaVA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task7.V21.Test
{
    [TestClass]
  
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\виктория\Desktop\DataSprint5\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);

        }
    }
}
