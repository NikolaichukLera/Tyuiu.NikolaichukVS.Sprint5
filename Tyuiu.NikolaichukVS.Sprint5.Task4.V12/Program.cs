using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NikolaichukVS.Sprint5.Task4.V12.Lib;

namespace Tyuiu.NikolaichukVS.Sprint5.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Николайчук В. С.| РПСБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Николайчук Валерия Сергеевна | РПСБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную С:DataSprint5 и скопировать в неё файл, в        *");
            Console.WriteLine("* котором есть вещественное значение. Прочитать значение из файла и       *");
            Console.WriteLine("* подставить вместо Х в формуле y = cos(x^3) + x/2. Вычислить значение по *");
            Console.WriteLine("* формуле (Полученное значение округлить до трёх знаков после запятой) и  *");
            Console.WriteLine("* вернуть полученный результат на консоль.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V12.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
           
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
