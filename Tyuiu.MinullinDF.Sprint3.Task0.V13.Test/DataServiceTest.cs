using Tyuiu.MinullinDF.Sprint3.Task0.V13.Lib;

namespace Tyuiu.MinullinDF.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 0.5;
            int k = 1;
            var res = ds.GetSumSeries(a, k, 20);
            double wait = 0.298;
            Assert.AreEqual(res, wait);

        }
    }
}
