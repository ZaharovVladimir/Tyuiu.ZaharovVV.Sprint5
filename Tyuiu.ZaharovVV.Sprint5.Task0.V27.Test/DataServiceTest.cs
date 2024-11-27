using Tyuiu.ZaharovVV.Sprint5.Task0.V27.Lib;

namespace Tyuiu.ZaharovVV.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}