using System.Text.Json;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MinullinDF.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            do 
            {
                s += (Math.Pow(value, startValue)+0.5)*Math.Cos(startValue);
                startValue++;
            } while (startValue < stopValue);
            return Math.Round(s, 3);
        }
    }
}
