using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EvseevEI.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.7 != 0)
                {
                    y = Math.Round(((Math.Sin(x) / (x + 1.7)) - Math.Cos(x) * 4 * x - 6), 2);

                }
                else
                {
                    y = 0;
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
            {

            }
        }
    }
}
