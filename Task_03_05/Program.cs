namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во время работы программы

            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            if (!double.TryParse(Console.ReadLine(), out double startCelsius)) //вводим переменную начальные цельсия и проверяем вводимые данные пользователем на корректность
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
            if (step <= 0) //проверяем на наличие ошибок вбиваемых данных
            {
                Console.WriteLine("Шаг должен быть положительным числом.");
                return;
            }

            Console.WriteLine("-------------------------"); //создаем таблицу, чтобы позже вносить в нее данные
            Console.WriteLine("| Цельсий | Фаренгейт |");
            Console.WriteLine("-------------------------");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32; // вычисляем значение в фаренгейтах
                Console.WriteLine($"| {celsius,7:F2} | {fahrenheit,10:F2} |"); //вносим данные в таблицу
            }

            Console.WriteLine("-------------------------"); //закрываем таблицу
        }
    }
}