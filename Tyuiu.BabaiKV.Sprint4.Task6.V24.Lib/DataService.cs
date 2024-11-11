﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabaiKV.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length > 7);
            return res;
        }
    }
}
