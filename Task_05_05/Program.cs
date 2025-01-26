namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнениеслучайными числами в диапазоне от - 99 до 99 включительно.Осуществите без создания нового массива преобразование текущего• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
            Console.WriteLine("Введите количество строк:");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введите число: ");
                return;
            }
            Console.WriteLine("Введите количество столбцов:");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Введите число: ");
                return;
            }
            int[,] mass = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = rnd.Next(-99, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mass[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(mass[i, j]) + " ");
                    }
                    else if (mass[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("1 ");
                        mass[i, j] = 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(mass[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
