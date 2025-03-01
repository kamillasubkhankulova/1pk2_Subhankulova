using System.CodeDom.Compiler;

namespace Task_10_06
{
    internal class Program
    {


        //Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит на консоль сгенерированный массив размерности n*n.
        public static void ArrayGeneration(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Размер массива должен быть больше нуля");
                return;
            }

            Random rnd = new Random();
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                }
            }
            PrintArray(array);
        }
        /// <summary>
        /// выводит на консоль сгенерированный массив размерности n*n.
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>массив с заданной размерностью</returns>

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Введите размер массива : ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                ArrayGeneration(n);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
