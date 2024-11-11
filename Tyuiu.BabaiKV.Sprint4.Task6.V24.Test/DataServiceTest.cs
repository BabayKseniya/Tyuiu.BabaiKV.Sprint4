using Tyuiu.BabaiKV.Sprint4.Task6.V24.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = ["Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура"];
            string[] wait = ["Компьютер", "Клавиатура"];
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}