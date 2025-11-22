using Tyuiu.BukinTK.Sprint5.Task4.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask4V25.txt";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Данные находятся в файле " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}