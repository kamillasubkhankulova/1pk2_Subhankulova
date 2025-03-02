using System.Data;
using System.Data.Common;

namespace Task_10_08
{
    internal class Program
    //Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индексискомогоэлемента в массиве. Если элемента нет – верните индекс = -1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для поиска:");
            if(!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введите число!!!");
                return;
            }
            int arrsize = 10;
            int[] mass = new int[arrsize];
            Random rnd = new Random();
            for (int i = 0; i < arrsize; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            int index = FindElement(mass, n);
            if (index != -1)
            {
                Console.WriteLine($"Элемент {n} под индексом: {index}");
            }
            else
            {
                Console.WriteLine($"Элемент {n} не найден");
            }
            Console.WriteLine(" Массив:");
            PrintArray(mass);
        }
        /// <summary>
        /// ищет элемент в массиве
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="n">число</param>
        /// <returns>индекс элемента</returns>
        public static int FindElement(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    return i; 
                }
            }
            return -1; 
        }
        /// <summary>
        /// выводит массив
        /// </summary>
        /// <param массив="mass"></param>
        public static void PrintArray(int[] mass)
        {
            Console.WriteLine("[");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i]);
                if (i < mass.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("]");
        }
    }
}

    
    

