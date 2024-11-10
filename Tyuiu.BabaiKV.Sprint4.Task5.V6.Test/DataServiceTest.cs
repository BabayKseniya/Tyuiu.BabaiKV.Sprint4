using Tyuiu.BabaiKV.Sprint4.Task5.V6.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {{-1,-2,-3,1,-1},
                                          {-2,-3,4,5,3},
                                          {1,2,3,4,5},
                                          {-1,2,4,3,-2},
                                          {1,2,4,-3,-1}};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = {{-1,-2,-3,1,-1},
                                          {-2,-3,1,1,1},
                                          {1,1,1,1,1},
                                          {-1,1,1,1,-2},
                                          {1,1,1,-3,-1}};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}