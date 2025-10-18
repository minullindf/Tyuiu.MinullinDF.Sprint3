using Tyuiu.MinullinDF.Sprint3.Task0.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double a = 0.5;
        int k = 1;
        int stopValue = 20;
        Console.WriteLine("Переменная a = " + a);
        Console.WriteLine("Старт шага = " + k);
        Console.WriteLine("Конец шага = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(a, k, stopValue));
        Console.ReadKey();
    }
}