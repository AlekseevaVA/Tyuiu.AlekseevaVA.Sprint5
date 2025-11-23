using System.IO;

using Tyuiu.AlekseevaVA.Sprint5.Task2.V11.Lib;


namespace Tyuiu.AlekseevaVA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);

        }
    }
}
