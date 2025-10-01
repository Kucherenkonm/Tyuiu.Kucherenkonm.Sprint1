using Tyuiu.Kucherenkonm.Sprint1.Task6.V11.Lib;
namespace Tyuiu.Kucherenkonm.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "tasksixtest";
            bool wait = true;
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            Assert.AreEqual(wait, res);
        }
    }
}
