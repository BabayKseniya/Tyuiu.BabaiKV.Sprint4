﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabaiKV.Sprint4.Task5.V6.Lib
{
    public class DataService : ISprint4Task5V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int[,] array = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = matrix[i, j];
                    }
                }
            }
            return array;
        }
    }
}