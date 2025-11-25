using Tyuiu.AlekseevaVA.Sprint5.Task3.V18.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task3.V18.Test
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
