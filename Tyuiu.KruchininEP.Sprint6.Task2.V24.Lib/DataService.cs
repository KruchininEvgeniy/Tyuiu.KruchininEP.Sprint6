using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KruchininEP.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 - i != 0)
                {
                    y = (Math.Sin(i)) + ((Math.Cos(i) + 1) / (2 - i)) + (2 * i);
                    y = Math.Round(y, 2);
                    res[count] = y;
                }
                else
                {
                    res[count] = 0;
                }
                count++;
            }
            return res;
        }
    }
}