using Tyuiu.ArkhipovaMD.Sprint3.Task0.V27.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;
            var result = ds.GetSumSeries(value, startValue, stopValue);
            var expect = 17.286;
            Assert.AreEqual(expect, result);
        }
    }
}
