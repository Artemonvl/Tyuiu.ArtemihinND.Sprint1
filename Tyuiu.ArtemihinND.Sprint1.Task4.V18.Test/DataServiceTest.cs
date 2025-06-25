using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint1.Task4.V18.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 0.062;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
