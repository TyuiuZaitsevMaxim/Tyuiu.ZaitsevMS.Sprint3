using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task1.V5.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double p = 1;
            for (int k = 1; k <= 10; k++)
            {
                p *= (Math.Cos(0.1) + Math.Pow(k, -2));
            }
            double expected = Math.Round(p, 3);

            Assert.AreEqual(expected, res);
        }
    }
}