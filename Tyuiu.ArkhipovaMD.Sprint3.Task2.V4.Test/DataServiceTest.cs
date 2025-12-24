using Tyuiu.ArkhipovaMD.Sprint3.Task2.V4.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            var res = ds.GetMultiplySeries(startValue, stopValue);
            var exp = 12.271;
            Assert.AreEqual(exp, res);
        }
    }
}
