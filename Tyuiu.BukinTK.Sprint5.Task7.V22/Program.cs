using Tyuiu.BukinTK.Sprint5.Task7.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
        string saveFilePath = @"C:\Users\timop\AppData\Local\Temp\OutPutDataFileTask7V22.txt";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Данные находятся в файле " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле:");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}