using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikolaichukVS.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadToEnd();
                string[] linestr = line.Split();
                int count = 0;
                for (int i = 0; i < linestr.Length-1; i++)
                {

                    if (linestr[i].Length == 2)
                    {
                        count++;
                    }
                        
                        
                }

                if (linestr[linestr.Length-1].Length == 3)
                {
                    count++;
                }
                return count;


            }
            

        }
    }
}
