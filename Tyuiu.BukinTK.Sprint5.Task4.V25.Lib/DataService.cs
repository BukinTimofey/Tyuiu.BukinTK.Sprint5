using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.', ',');
            double x = (Convert.ToDouble(strx));
            return Math.Round((Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x), 3);
        }
    }
}
