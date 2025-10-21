using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double ans = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i !=0)
                {
                    ans += ((Math.Cos(i) + Math.Sin(i)) / i);
                }
            }
            return ans;
        }
    }
}
