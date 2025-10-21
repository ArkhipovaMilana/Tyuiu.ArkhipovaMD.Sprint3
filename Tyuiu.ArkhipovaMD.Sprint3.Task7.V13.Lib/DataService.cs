using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] m = new double[11];
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) == -1)
                {
                    m[cnt] = 0;
                }
                else
                {
                    m[cnt] = 3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1));
                }
                cnt++;
            }
            return m;
        }
    }
}
