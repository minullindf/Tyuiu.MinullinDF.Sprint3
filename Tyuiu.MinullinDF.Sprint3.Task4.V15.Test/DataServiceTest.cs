using Tyuiu.MinullinDF.Sprint3.Task4.V15.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x1 = -5;
            int x2 = 5;
            var res = ds.Calculate(x1, x2);
            double wait = 623.499;
            Assert.AreEqual(wait, res);
        }
    }
}
