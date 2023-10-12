using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint1.Task1.V11.Lib;
namespace Tyuiu.BreslavskyaIV.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 5.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(1, res);
        }
    }
}
