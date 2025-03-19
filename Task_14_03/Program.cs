using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Task_14_03
{
    internal class Program
    {
        //Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте так, чтобы метод работал только для неотрицательных чисел.
        static void Main(string[] args)
        {
            int num = 5;
            long factorial = Factorial(num);

            if (factorial != -1)
            {
                Console.WriteLine($"Факториал {num} = {factorial}");
            }
            else
            {
                Console.WriteLine("Факториал определен только для неотрицательных чисел.");
            }
        }
        static long Factorial(int num)
        {
            if (num < 0)
            {
                return -1;
            }
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}