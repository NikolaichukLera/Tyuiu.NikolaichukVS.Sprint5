using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NikolaichukVS.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Cos(Math.Pow((Convert.ToDouble(strX)), 3)) + ((Convert.ToDouble(strX)) / 2);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
