using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabaiKV.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length/rows;
            int c = -10000;
            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < colums; j++)
                {


                    if (i == 1)
                    {
                        c = Math.Max(c, array[i, j]);
                    }
                }
            }
            return c;
        }
    }
}
