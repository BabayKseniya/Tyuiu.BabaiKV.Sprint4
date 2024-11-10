using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabaiKV.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int c = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    c *= array[i];
                }
            }
            return c;
        }
    }
}
