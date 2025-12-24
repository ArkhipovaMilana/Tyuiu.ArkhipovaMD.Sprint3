using Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task7.V13.Test
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
            var res = ds.GetMassFunction(startValue, stopValue)[0];
            var exp = 4.35;
            Assert.AreEqual(exp, res);
        }
    }
}
