using Tyuiu.EvseevEI.Sprint6.Task0.V9.Lib;
namespace Tyuiu.EvseevEI.Sprint6.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new();
            double res = ds.Calculate(1);
            double wait = 3;
            Assert.AreEqual(wait,res); 
            
        }
    }
}