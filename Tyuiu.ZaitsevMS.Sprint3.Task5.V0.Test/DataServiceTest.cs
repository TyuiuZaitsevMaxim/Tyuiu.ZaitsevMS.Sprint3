using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task5.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 5;
            int startValue2 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1 , stopValue2);

            double wait = 282.762;

            Assert.AreEqual(wait, res);
        }
    }
}
