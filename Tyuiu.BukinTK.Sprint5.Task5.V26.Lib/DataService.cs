using System.Globalization;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double positive = 0;
            double negative = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                        {
                            if (number >= 0)
                            {
                                positive += number;
                            }
                            else
                            {
                                negative += number;
                            }
                        }
                    }
                }
            }
            res = Math.Round(positive - negative, 3);
            return res;
        }
    }
}
