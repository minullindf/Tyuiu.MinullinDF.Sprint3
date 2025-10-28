using Tyuiu.MinullinDF.Sprint3.Task7.V8.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task7.V8.Test
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
            var res = ds.GetMassFunction(x1, x2);
            double[] wait = new double[x2 - x1 + 1];

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
