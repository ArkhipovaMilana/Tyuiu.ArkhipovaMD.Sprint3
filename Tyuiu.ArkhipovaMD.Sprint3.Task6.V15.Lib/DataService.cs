using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int s = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 2; j<=i; j++)
                {
                    if (i%j==0)
                    {
                        s += j;
                    }
                }
            }
            return s;
        }
    }
}
