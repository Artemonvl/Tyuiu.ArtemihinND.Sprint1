using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint1.Task6.V18.Lib;

namespace Tyuiu.ArtemihinND.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            
            string strTest1 = "1*2*2";
            string strTest2 = "3*4";
            DataService ds = new DataService();

            
            string res = ds.CheckNumber(strTest1, strTest2);
            string wait = "122, 34";

            
            Assert.AreEqual(wait, res);
        }

    }
}
