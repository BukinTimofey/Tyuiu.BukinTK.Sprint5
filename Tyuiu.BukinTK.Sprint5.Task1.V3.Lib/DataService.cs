using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(tempFilePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(tempFilePath);
            }

            double y;
            string strX;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = x;
                if (y + 2.5 == 0) {
                    y = 0;
                } else
                {
                    y = Math.Round(Math.Cos(y * 2) + Math.Sin(y) / (y + 2.5) + 2 * y, 2);
                }
                strX = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(tempFilePath, strX + Environment.NewLine);
                } else
                {
                    File.AppendAllText(tempFilePath, strX);
                }
            }
            return tempFilePath;
        }
    }
}
