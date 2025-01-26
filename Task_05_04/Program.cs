using System;
using System.Drawing;

namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица диагональной(все элементы вне главной диагонали равны нулю)Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси сообщение что матрица не является диагональной.
            int n = 3;
            int[,] mass = new int[n, n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = (char)(rnd.Next(0, 10));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool dio = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && mass[i, j] != 0)
                    {
                        dio = false;
                    }
                }
            }

            if (dio)
            {
                Console.WriteLine("Матрица является диагональной. Вывод с выделением главной диагонали:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan; 
                            Console.Write(mass[i, j] + " ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White; 
                            Console.Write(mass[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }

            Console.ResetColor();
        }
    }
}
