using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task1.V5.Lib 
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                result = result * (Math.Cos(0.1) + Math.Pow(k, -2));
                k++;
            }
            return Math.Round(result, 3);
        }
    }
}