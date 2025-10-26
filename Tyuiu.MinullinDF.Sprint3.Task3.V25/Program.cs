using Tyuiu.MinullinDF.Sprint3.Task3.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        String text = "kjhgfuu gujut dtuu";
        Char c = 'u';
        Console.WriteLine("Буква = " + c);
        Console.WriteLine("Текст = " + text);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Мин. кол-во пар буквы {c}  = {ds.GetMinCharCount(text, c)}");
        Console.ReadKey();
    }
}