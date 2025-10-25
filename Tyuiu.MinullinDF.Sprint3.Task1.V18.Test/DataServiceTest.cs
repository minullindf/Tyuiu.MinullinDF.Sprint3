using Tyuiu.MinullinDF.Sprint3.Task1.V18.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int endValue = 15;
            var res = ds.GetSumSeries(startValue, endValue);
            double wait = 0.121;
            Assert.AreEqual(wait, res);
        }
    }
}
