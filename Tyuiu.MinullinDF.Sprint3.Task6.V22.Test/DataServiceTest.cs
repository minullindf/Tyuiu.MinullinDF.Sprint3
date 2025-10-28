using Tyuiu.MinullinDF.Sprint3.Task6.V22.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 19;
            int j = 31;
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(i, j);
            Assert.AreEqual(55, res);
        }
    }
}
