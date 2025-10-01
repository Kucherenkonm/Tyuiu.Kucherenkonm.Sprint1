using Tyuiu.Kucherenkonm.Sprint1.Task5.V3.Lib;
namespace Tyuiu.Kucherenkonm.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();

            int k = 130985;
            int res = ds.Calculate(k);
            int result = Convert.ToInt32(res);
            int h = 9;
            Assert.AreEqual(h, result);

        }
    }
}
