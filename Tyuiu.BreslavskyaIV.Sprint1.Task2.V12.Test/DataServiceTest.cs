using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint1.Task2.V12.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            int z = 1;
            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(1, res);
            
        }
    }
}