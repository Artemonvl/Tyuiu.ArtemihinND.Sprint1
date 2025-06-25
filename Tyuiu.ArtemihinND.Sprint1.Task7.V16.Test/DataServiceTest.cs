using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint1.Task7.V16.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double wait = 0.036;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
