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
            double x = 2;
            double y = 4;
            double wait = -1.782;
            var res = ds.Calculate(x , y);
            Assert.AreEqual(wait, res);
        }
    }
}
