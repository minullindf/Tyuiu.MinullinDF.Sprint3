using Tyuiu.MinullinDF.Sprint3.Task4.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x1 = -5;
        int x2 = 5;
        Console.WriteLine($"Промежуток от {x1} до {x2}");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Произведение всех y  = {ds.Calculate(x1, x2)}");
        Console.ReadKey();
    }
}