using Tyuiu.StryzhakMA.Sprint1.Task7.V23.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.265;
            var res = ds.Calculate(x , y);
            Assert.AreEqual(wait, res);
        }
    }
}
