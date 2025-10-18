using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double r = 1;
            do
            {
                double re = Math.Pow((double)startValue / (double)Math.Pow((double)Math.Sin(1), -7), -2);
                r = (double)r * re;
                startValue++;
            }while (startValue<=stopValue);
            return Math.Round(r,3);
        }
    }
}
