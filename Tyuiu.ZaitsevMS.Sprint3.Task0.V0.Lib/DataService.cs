using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task0.V0.Lib
{
    public class DataService : ISprint3Task0V0
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((1 / Math.Sin(i)) + value);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
