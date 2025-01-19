using System;

namespace Task_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("| X  |  Y |");
            Console.WriteLine("-------------------------");
            for (double x = -5; x <= 4; x += 0.5)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"| {x,6:F2} | {y,6:F2} |");
            }
            Console.WriteLine("------------------");
        }
    }
}