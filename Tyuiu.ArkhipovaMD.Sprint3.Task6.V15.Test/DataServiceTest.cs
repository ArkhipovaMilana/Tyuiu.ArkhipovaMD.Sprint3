using Tyuiu.ArkhipovaMD.Sprint3.Task6.V15.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = 21;
            int startValue = 1;
            int stopValue = 5;
            var res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(exp, res);
        }
    }
}
