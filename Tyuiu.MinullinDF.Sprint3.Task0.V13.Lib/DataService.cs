using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MinullinDF.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                s += (Math.Pow(value, k)+0.5)*Math.Cos(k);
            }
            return Math.Round(s, 3);
        }
    }
}
