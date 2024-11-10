using Tyuiu.BabaiKV.Sprint4.Task0.V19.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Бабай К.В. | СМАРТб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };


            Console.WriteLine(" Исходный массив:");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
                


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результирующий массив:");
            Console.WriteLine("Произведение нечётных элементов массива: " + ds.GetMultOddArrEl(numsArray));

            Console.ReadKey();
        }
    }
}
