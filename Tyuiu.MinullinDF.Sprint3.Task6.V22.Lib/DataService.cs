using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MinullinDF.Sprint3.Task6.V22.Lib
{
    public class DataService : ISprint3Task6V22
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int a = 0;
            for (x = startValue; x <= stopValue; x++) 
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0) 
                    {
                        a += 1;
                    }
                }
            }
            return a;
        }
    }
}
