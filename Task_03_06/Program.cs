using System;

namespace Task_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: у= |х| для -45x≤4, с шагом h = 0,5.
            Console.WriteLine("-------------------------"); //создаем таблицу
            Console.WriteLine("| X  |  Y |");
            Console.WriteLine("-------------------------");
            for (double x = -5; x <= 4; x += 0.5) //проверяем условия
            {
                double y = Math.Abs(x);
                Console.WriteLine($"| {x,6:F2} | {y,6:F2} |"); //вносим данные 
            }
            Console.WriteLine("------------------");
        }
    }
}