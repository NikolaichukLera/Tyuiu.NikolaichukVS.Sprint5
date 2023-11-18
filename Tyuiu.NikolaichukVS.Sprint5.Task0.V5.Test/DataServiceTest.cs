using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint5.Task0.V5.Lib;

using System.IO;
namespace Tyuiu.NikolaichukVS.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.NikolaichukVS.Sprint5\Tyuiu.NikolaichukVS.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
