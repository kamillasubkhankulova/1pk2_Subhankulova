using System.Security.Cryptography.X509Certificates;

namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вклад в банке составляет х рублей. Ежегодно он увеличивается на р процентов, после чего дробная часть копеек отбрасывается.Каждый год сумма вклада становится больше.Определите, через сколько лет вклад составит не менее у рублей.
                        Console.Write("Введите начальную сумму вклада: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.Write("Введите процент годовых: ");
            if (!double.TryParse(Console.ReadLine(), out double p))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.Write("Введите конечную сумму вклада: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }
            if (x <= 0 || p <= 0 || y <= x)
            {
                Console.WriteLine("Некорректные входные данные");
                return;
            }


            int years = 0;
            while (x < y)
            {
                x = Math.Floor(x * (1 + p / 100));
                years++;
            }

            Console.WriteLine($"Через {years} лет вклад составит не менее {y} рублей.");
        }
    }
}