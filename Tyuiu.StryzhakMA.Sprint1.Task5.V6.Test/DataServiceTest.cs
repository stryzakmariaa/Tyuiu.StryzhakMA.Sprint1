using Tyuiu.StryzhakMA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpretion()
        {
            
            DataSetvice ds = new DataSetvice();

            
            int k = 8;

            
            int wait = 1;

            
            int res = ds.Calculate(k);

            
            Assert.AreEqual(wait, res);
        }
    }
}
