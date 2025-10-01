﻿using Tyuiu.Kucherenkonm.Sprint1.Task7.V14.Lib;
namespace Tyuiu.Kucherenkonm.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.869, res);
        }
    }
}
