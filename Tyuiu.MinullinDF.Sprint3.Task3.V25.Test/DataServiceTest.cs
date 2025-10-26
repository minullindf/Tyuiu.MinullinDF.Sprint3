using Tyuiu.MinullinDF.Sprint3.Task3.V25.Lib;
namespace Tyuiu.MinullinDF.Sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            String text = "kjhgfuu gujut dtuu";
            Char c = 'u';
            var res = ds.GetMinCharCount(text, c);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
