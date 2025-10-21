using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                sum += Math.Cos(i) + 4;
            }
            for (int i = startValue2; i <= stopValue2; i++)
            {
                sum += sum;
            }
            return Math.Round(sum);
        }
    }
}
