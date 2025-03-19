using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Task_14_03
{
    internal class Program
    {
        //Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте так, чтобы метод работал только для неотрицательных чисел.
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long factorialResult = Factorial(number);
            if (factorialResult != -1)
            {
                    Console.WriteLine($"Факториал числа {number} равен {factorialResult}");
            }
            Console.ReadKey();
        }
        static long Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Факториал определен только для неотрицательных чисел.");
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}