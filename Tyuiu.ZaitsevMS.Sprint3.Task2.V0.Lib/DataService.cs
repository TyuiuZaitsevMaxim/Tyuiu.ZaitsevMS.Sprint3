using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;
            do
            {
                sumSeries = sumSeries + (Math.Pow(value, k) + 0.5) * Math.Cos(k);
                k++;
            } while (k <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}