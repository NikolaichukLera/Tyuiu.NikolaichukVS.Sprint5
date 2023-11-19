using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaichukVS.Sprint5.Task2.V23.Lib;
using System.IO;

namespace Tyuiu.NikolajchukVS.Sprint5.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChtckedExistsFile()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.NikolaichukVS.Sprint5\Tyuiu.NikolaichukVS.Sprint5.Task2.V23\bin\Debug\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
