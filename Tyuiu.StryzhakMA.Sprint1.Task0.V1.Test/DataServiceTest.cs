using Tyuiu.StryzhakMA.Sprint1.Task0.V1.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-6, res);
        }
    }
}
