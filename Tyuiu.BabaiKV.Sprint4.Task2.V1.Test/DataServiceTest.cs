using Tyuiu.BabaiKV.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 98304;
            Assert.AreEqual(wait, res);
        }
    }
}