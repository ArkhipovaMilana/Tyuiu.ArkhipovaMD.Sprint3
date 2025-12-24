using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue+1;
            double[] m = new double[len];
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) == -1)
                {
                    m[cnt] = 0;
                }
                else
                {
                    m[cnt] = Math.Round(3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1)),2);
                }
                cnt++;
            }
            return m;
        }
    }
}
