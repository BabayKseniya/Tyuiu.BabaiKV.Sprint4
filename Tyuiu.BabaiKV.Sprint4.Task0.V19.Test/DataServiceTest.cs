using Tyuiu.BabaiKV.Sprint4.Task0.V19.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9,5,7,4,5,3,7,8,9,1 };
            int res  = ds.GetMultOddArrEl(numsArray);
            int wait = 297675;
            Assert.AreEqual(wait, res );
        }
    }
}