using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
            int line1 = 3;
            int cols1 = 3;
            int line2 = 3;
            int cols2 = 3;
            char[,] mass1 = new char[line1, cols1];
            Random random1 = new Random();
            for (int i = 0; i < line1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    mass1[i, j] = (char)('a' + random1.Next(0, 26));
                }
            }
            for (int i = 0; i < line1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(mass1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
            char[,] mass2 = new char[line2, cols2];
            Random random2 = new Random();
            for (int i = 0; i < line2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    mass2[i, j] = (char)('a' + random2.Next(0, 26));
                }
            }
            for (int i = 0; i < line2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(mass2[i, j] + " ");
                }
                Console.WriteLine("    ");

            }
            bool rav = true;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass1[i, j] != mass2[i, j])
                    {
                        rav = false;
                    }
                }
            }

            if (rav)
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                Console.WriteLine("Матрицы не равны.");


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (mass1[i, j] == mass2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green; 
                            Console.Write(mass1[i, j] + " ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;   
                            Console.Write(mass1[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.ResetColor(); 
            }
        }
    }
}