using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint1.Task4.V13.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 0.0;
          
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.123, res);
        }
    }
}
