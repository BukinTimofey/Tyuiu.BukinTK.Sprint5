using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            double strx = Convert.ToDouble(File.ReadAllText(path));
            return Math.Round((Math.Pow(strx, 4) + Math.Cos(strx)) * Math.Sin(strx), 3);
        }
    }
}
