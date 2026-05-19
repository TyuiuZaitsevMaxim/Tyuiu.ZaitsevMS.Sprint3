using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task0.V30.Lib 
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                result = result * Math.Pow(k / Math.Sin(1), -10);
            }
            return Math.Round(result, 3);
        }
    }
}