using System.IO;

namespace Tyuiu.BukinTK.Sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\timop\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
