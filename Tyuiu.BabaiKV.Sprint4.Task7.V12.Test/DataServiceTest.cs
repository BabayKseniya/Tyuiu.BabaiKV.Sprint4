using Tyuiu.BabaiKV.Sprint4.Task7.V12.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int [n,m];
            string value = "658932125478";
            DataService ds = new DataService();
            int res = ds.Calculate(n,m,value);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}