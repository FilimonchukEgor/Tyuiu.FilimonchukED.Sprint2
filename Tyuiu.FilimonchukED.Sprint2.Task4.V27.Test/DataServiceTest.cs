using Tyuiu.FilimonchukED.Sprint2.Task4.V27.Lib;
namespace Tyuiu.FilimonchukED.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double wait = 99.867;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
