﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task5.V3.Lib
{
    public class DataService: ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            var h = (k % 1000 - k % 100)/100;
            return h;
        }
    }
}
