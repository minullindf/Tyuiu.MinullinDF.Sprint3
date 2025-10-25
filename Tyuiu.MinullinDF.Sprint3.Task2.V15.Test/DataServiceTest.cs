using Tyuiu.MinullinDF.Sprint3.Task2.V15.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.5;
            int startValue = 1;
            int endValue = 20;
            var res = ds.GetSumSeries(a, startValue, endValue);
            var wait = 0.094;
            Assert.AreEqual(wait, res);
        }
    }
}
