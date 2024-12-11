using Tyuiu.EvseevEI.Sprint6.Task5.V12.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string[] paths = {  };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}