using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task3.V6.Lib
{
    public class DataService: ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            return Math.Round(distance / 100 * gasFlow * gasPrice*2, 3);
        }
    }
}
