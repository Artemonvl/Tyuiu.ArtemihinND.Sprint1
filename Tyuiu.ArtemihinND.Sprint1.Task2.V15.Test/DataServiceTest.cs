using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ArtemihinND.Sprint1.Task2.V15.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(8, res);
        }
    }
}
