using Tyuiu.ArkhipovaMD.Sprint3.Task1.V4.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 1;
            var res= ds.GetSumSeries(a, b);
            var exp = 0;
            Assert.AreEqual(exp, res);
        }
    }
}
