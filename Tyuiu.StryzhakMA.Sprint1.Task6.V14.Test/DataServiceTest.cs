using Newtonsoft.Json.Linq;
using Tyuiu.StryzhakMA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "абвгд"; 
            DataService ds = new DataService();

            
            bool res = ds.CheckLowerCaseRusLetters(strTest);

            
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void InvalidString()
        {
            string strTest = "абвГд"; 
            DataService ds = new DataService();

            bool res = ds.CheckLowerCaseRusLetters(strTest);

            
            Assert.IsFalse(res);
        }
    }
}
