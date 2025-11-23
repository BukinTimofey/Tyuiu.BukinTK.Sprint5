using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BukinTK.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace('!', '#');
            strx = strx.Replace(',', '#');
            strx = strx.Replace('?', '#');
            strx = strx.Replace('-', '#');
            strx = strx.Replace('.', '#');
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            File.WriteAllText(tempFilePath, strx.ToString());
            return tempFilePath;
        }
    }
}
