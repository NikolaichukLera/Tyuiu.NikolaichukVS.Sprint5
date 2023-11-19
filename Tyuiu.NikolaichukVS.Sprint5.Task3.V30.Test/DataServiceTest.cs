using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint5.Task3.V30.Lib;

using System.IO;

namespace Tyuiu.NikolaichukVS.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ТИУ\source\repos\Tyuiu.NikolaichukVS.Sprint5\Tyuiu.NikolaichukVS.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
