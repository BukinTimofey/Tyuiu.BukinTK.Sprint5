using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(tempFilePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(tempFilePath);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i, j]+";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(tempFilePath, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(tempFilePath, str);
                }

                str = "";
            }
            return tempFilePath;
        }
    }
}
