using System.IO;
using System.Text;
using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(tempFilePath);

            double z = Math.Round(Math.Pow(x - 1, 3 * x + 1), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(tempFilePath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return tempFilePath;
        }
    }
}
