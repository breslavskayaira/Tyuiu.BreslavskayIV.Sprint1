using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.BreslavskyaIV.Sprint1.Task6.V14.Lib
{
    public class DataService: ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            int a = 0;
            for (int i = 0; i< value.Length; i++)
            {
                if (value[i] >= 'а' && value[i] <= 'я' || value[i] == 'ё')
                    a++;
            }

            if (a == value.Length)
                return true;
            else
                return false;
        }

    }
}
