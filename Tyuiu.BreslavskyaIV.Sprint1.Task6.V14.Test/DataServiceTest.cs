using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint1.Task6.V14.Lib;
namespace Tyuiu.BreslavskyaIV.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "фывапро";

            var h = ds.CheckLowerCaseRusLetters(value);
            Assert.AreEqual(true, h);
        }
    }
}
