namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными числами в диапазоне от 10 до 99 включительно. Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
                Console.WriteLine("Введите число, которое будет являться количеством строк и столбцов:");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("Введите число");
                    return;
                }
                int[,] mass = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i, j] = rnd.Next(10, 100);
                        Console.Write(mass[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int min = 100;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[i, j] < min)
                    {
                        min = mass[i, j];
                        
                    }

                }
                Console.WriteLine("---------------------------------------------------------------");
                


            }

                Console.WriteLine($"Минимальное число:{min}");
            

            }
        }
    }

