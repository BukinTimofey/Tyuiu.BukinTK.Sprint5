using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task0.V17.Lib

{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Round(2.4 * Math.Pow(x, 2) + 0.4 * Math.Pow(x, 2) - 14 * x + 41, 3);
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(tempFilePath, result.ToString());
            return tempFilePath;
        }
    }
}
