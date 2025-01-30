namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей (это матрица, где все недиагональные элементы меньше нуля) Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то вывести сообщение что данная матрица не является Z - матрицей
            Console.WriteLine("Введите размер массива");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введите число!");
                return;
            }
            int[,] mass = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)//диагональ
                    {
                        mass[i, j] = rnd.Next(1, 11);
                    }
                    else
                    {
                        mass[i, j] = rnd.Next(-9, 1);
                    }
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            bool Z = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (mass[i, j] > 0)
                        {
                            Z = false;
                            break;
                        }
                    }
                }
                if (!Z)
                {
                    break;
                }
            }
            if (Z)
            {
                Console.WriteLine("\nМатрица Z-образная");
                Console.WriteLine("Матрица+ главная диагональ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(mass[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(mass[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nМатрица не z-образная");
            }
            Console.ReadKey();
        }
    }
}



    
