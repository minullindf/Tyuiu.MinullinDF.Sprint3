using Tyuiu.MinullinDF.Sprint3.Task5.V13.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int i1 = 1;
            int i2 = 3;
            int k1 = 1;
            int k2 = 12;
            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(x, i1, i2, k1, k2);
            double wait = 37.837;
            Assert.AreEqual(wait, res);

        }
    }
}
