using System.Runtime.Serialization.Formatters;

namespace Task_08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5
            for (int n = 20; n <= 50; n++)
            {
                if (n % 3 == 0 & n % 5 != 0)
                {
                    Console.WriteLine(n);
                }
            }


        }
    }
}
