﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskyaIV.Sprint1.Task3.V6.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу    *");
            Console.WriteLine("* (туда и обратно)                                                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double distance = 67.0;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            Console.WriteLine("Расстояние до дачи(км) = " + distance);
            Console.WriteLine("Расход бензина (литров на 100 км пробега) = "+ gasFlow);
            Console.WriteLine("Цена литра бензина (руб.) = " + gasPrice);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(distance, gasFlow, gasPrice) + "руб.");
            Console.ReadLine();
        }
    }
}
