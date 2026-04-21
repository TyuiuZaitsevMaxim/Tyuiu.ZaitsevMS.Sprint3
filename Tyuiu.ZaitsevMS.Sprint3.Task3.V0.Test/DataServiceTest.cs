using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint3.Task3.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint3.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "abcdef abcdef abcdef abcdefabcdefabcdef";
            char chr = 'a';

            double res = ds.GetCharCount(str, chr);

            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
