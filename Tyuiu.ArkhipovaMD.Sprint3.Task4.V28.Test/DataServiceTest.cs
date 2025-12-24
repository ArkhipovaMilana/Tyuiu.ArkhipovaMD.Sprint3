using Tyuiu.ArkhipovaMD.Sprint3.Task4.V28.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = 0.858;

            int startValue = 1;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(exp, res);
        }
    }
}
