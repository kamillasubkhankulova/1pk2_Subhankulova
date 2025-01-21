namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            if (!double.TryParse(Console.ReadLine(), out double startCelsius))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            if (!double.TryParse(Console.ReadLine(), out double endCelsius))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            Console.Write("Введите шаг изменения температуры: ");
            if (!double.TryParse(Console.ReadLine(), out double step))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }
            if (step <= 0)
            {
                Console.WriteLine("Шаг должен быть положительным числом.");
                return;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("| Цельсий | Фаренгейт |");
            Console.WriteLine("-------------------------");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"| {celsius,7:F2} | {fahrenheit,10:F2} |");
            }

            Console.WriteLine("-------------------------");
        }
    }
}