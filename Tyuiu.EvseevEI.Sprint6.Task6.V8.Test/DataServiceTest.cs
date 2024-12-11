using Tyuiu.EvseevEI.Sprint6.Task6.V8.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\evseevegor709icloud\source\repos\Tyuiu.EvseevEI.Sprint6\Tyuiu.EvseevEI.Sprint6.Task6.V8\InPutDataFileTask6V8.txt";

            var res = ds.CollectTextFromFile(path);
            string wait = "RizdogMOZpCb GqzgGQOdWpd ztMvvn";
            Assert.AreEqual(wait, res);
        }
    
    }
}