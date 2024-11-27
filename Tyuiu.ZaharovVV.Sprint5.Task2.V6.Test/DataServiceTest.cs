using Tyuiu.ZaharovVV.Sprint5.Task2.V6.Lib;

namespace Tyuiu.ZaharovVV.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -2, 1, 8 },
                          { -4, -7, 8 },
                          { 6, 5, 5 } };
            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}