using Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = 115.748;
            int x = 2;
            int startvalue1 = 1;
            int startvalue2 = 1;
            int stopvalue1 = 3;
            int stopvalue2 = 10;
            var res = ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2);
            Assert.AreEqual(exp, res);
        }
    }
}
