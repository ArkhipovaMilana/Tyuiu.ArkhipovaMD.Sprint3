using Tyuiu.ArkhipovaMD.Sprint3.Task3.V23.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint3.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = "fd88t 8iu v8r8";
            string a = "fdsst siu vsrs";
            char b = 's';
            char c = '8';
            var res = ds.ReplaceCharOnNum(a, b, c);
            Assert.AreEqual(exp, res);
        }
    }
}
