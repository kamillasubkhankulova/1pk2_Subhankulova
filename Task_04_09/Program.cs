using System;

namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и вывести уникальные элементы массива. (LINQ использовать нельзя)
            int[] number = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1,20);
                Console.Write("  "+ number[i]);
            }
            int temp = 0;
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                temp = number[i];
                count = 0;
                for (int j = 0; j < 20; j++)
                {
                    if (number[j] == temp)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine( temp);
                }
            }







        }
    }
}
