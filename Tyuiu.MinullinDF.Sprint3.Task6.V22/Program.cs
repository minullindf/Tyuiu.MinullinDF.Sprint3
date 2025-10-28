using Tyuiu.MinullinDF.Sprint3.Task6.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int i = 19;
        int j = 31;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Кол-во делителей отрезка [{i};{j}]  = {ds.GetSumTheDivisors(i, j)}");
        Console.ReadKey();
    }
}