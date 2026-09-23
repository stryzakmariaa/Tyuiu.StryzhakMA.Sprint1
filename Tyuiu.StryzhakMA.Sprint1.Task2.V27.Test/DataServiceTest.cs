using Tyuiu.StryzhakMA.Sprint1.Task2.V27.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 12;
            var res = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(24, res);
        }
    }
}
