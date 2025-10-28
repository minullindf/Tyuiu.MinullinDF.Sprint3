using Tyuiu.MinullinDF.Sprint3.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = 5;
        int i1 = 1;
        int i2 = 1;
        int k1 = 3;
        int k2 = 12;
        Console.WriteLine($"x = {x}; i1 = {i1}; i2 = {i2}; k1 = {k1}; k2 = {k2}");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Сумма рядов суммы рядов  = {ds.GetSumSumSeries(x, i1, i2, k1, k2)}");
        Console.ReadKey();
    }
}