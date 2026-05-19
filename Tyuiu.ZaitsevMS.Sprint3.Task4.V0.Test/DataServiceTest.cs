using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task4.V29.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task4.V29.Test
{
    [TestClass] 
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}