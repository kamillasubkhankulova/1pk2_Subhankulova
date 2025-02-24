﻿using System.Runtime.Serialization.Formatters;

namespace Task_07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8;

            Console.WriteLine("------------------");
            Console.WriteLine("| Время | Скорость|");
            Console.WriteLine("------------------");

            for (double t = 0; t <= 15; t += 0.5)
            {
                double v = g * t;
                Console.WriteLine($"| {t,8:F1} | {v,14:F2} |");
            }

            Console.WriteLine("------------------");
        }
    }
}