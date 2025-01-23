namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t, где g = 9,8 м / с2 - ускорение свободного падения.

            const double g = 9.8; //вводим константу

            Console.WriteLine("---------------------------");
            Console.WriteLine("| Время    | Скорость      |"); // cоздаем таблицу
            Console.WriteLine("---------------------------");

            for (double t = 0; t <= 15; t += 0.5) //проверяем условия
            {
                double v = g * t; //выполняем вычисления
                Console.WriteLine($"| {t,8:F1} | {v,14}");
            }
        }
    }
}