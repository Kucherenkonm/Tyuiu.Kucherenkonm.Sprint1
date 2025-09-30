using Tyuiu.Kucherenkonm.Sprint1.Task2.V28.Lib;
namespace Tyuiu.Kucherenkonm.Sprint1.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            int x = 2;
            Assert.AreEqual(275, ds.ConvertCelsiusToKelvin(x));
        }
    }
}
