using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double y1 = 0;
            double x2 = 3;
            double y2 = 4;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
