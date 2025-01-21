namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8;

            Console.WriteLine("------------------");
            Console.WriteLine("| Время    | Скорость      |");
            Console.WriteLine("------------------");

            for (double t = 0; t <= 15; t += 0.5)
            {
                double v = g * t;
                Console.WriteLine($"| {t,8:F1} | {v,14}");
            }
        }
    }
}