using Tyuiu.FilimonchukED.Sprint2.Task6.V14.Lib;
namespace Tyuiu.FilimonchukED.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1,1));
            Assert.AreEqual("Вторник", ds.FindDayName(2,1));
            Assert.AreEqual("Среда", ds.FindDayName(3,1));
            Assert.AreEqual("Четверг", ds.FindDayName(4,1));
            Assert.AreEqual("Пятница", ds.FindDayName(5,1));
            Assert.AreEqual("Суббота", ds.FindDayName(6,1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7,1));
        }
    }
}
