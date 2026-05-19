using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task0.V30.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            // Вычисленное эталонное значение
            double expected = 0;
            double p = 1;
            for (int k = 1; k <= 20; k++)
            {
                p *= Math.Pow(k / Math.Sin(1), -10);
            }
            expected = Math.Round(p, 3);

            Assert.AreEqual(expected, res);
        }
    }
}