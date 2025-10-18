using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            while (startValue<=stopValue) 
            {
                double r =(double) 1/startValue;
                res +=Math.Pow(r,2);
                startValue++;
            }
            return Math.Round(res,3);
        }
    }
}
