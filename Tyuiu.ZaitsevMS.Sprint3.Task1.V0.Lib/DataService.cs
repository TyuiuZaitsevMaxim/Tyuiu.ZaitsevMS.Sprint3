using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaitsevMS.Sprint3.Task1.V0.Lib
{
    public class DataService : ISprint3Task1V0
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * ((1 / Math.Sin(startValue)) + value);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
