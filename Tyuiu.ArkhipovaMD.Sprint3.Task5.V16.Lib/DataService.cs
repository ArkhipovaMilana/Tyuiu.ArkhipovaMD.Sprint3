using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue2; i <= stopValue2; i++)
            {
                for (int k = startValue1; k <= stopValue1; k++)
                {
                    sum += Math.Cos(k) + x * x;
                }
            }
            return Math.Round(sum, 3);
        }
    }
}
