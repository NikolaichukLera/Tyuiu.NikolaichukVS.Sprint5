using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaichukVS.Sprint5.Task7.V24.Lib;
using System.IO;
namespace Tyuiu.NikolaichukVS.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
