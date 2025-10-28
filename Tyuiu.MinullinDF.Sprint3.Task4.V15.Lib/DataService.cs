using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MinullinDF.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) 
                {
                    continue;
                }
                y *= ((Math.Sin(x)+ (double)x) /(double)x) + 0.75;
            }
            return Math.Round(y,3);
        }
    }
}
