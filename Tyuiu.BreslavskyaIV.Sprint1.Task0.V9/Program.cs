using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskyaIV.Sprint1.Task0.V9.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                              *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет значение выражения (9/3)*4/3/2+1   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* (9/3)*4/3/2+1                                                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
