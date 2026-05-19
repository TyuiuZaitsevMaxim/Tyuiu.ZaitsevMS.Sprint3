using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task2.V15.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double s = 0;
            for (int k = 1; k <= 20; k++)
            {
                s += (Math.Pow(value, k) + 0.5) * Math.Cos(k);
            }
            double expected = Math.Round(s, 3);

            Assert.AreEqual(expected, res);
        }
    }
}