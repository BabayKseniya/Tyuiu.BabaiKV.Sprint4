using Tyuiu.BabaiKV.Sprint4.Task1.V28.Lib;
namespace Tyuiu.BabaiKV.Sprint4.Task1.V28
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
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int len;
            Console.WriteLine(" Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];


            
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение "+i+" элемента массива:");
                numsArray[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив : ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i]+ "\t");
                
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
