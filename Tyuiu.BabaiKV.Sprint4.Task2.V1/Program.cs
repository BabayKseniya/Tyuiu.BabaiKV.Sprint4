using Tyuiu.BabaiKV.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Бабай К.В. | СМАРТб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            
            Console.WriteLine(" Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];



            for (int i = 0; i <= len - 1; i++)
            {

                numsArray[i] = rnd.Next(1, 10);
            }
            Console.WriteLine();
            Console.WriteLine("Массив : ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine("Произведение чётных элементов = "+res);
            Console.ReadKey();
        }
    }
}
