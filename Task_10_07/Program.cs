using System.Security.Cryptography.X509Certificates;

namespace Task_10_07
{
    internal class Program
    //Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерныймассив(состоящийиз символов русского алфавита) и выведите на консоль данный массив с помощью другого метода(которыйпринимает данный массив в качестве параметра)
    {
        public static void Main(string[] args)
        {
            int rows = 5;
            int cols = 10;
            char[,] Mass=GenerateArray(rows, cols);
            PrintArray(Mass);
        }
        /// <summary>
        /// Генерирует массив
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
            public static char[,] GenerateArray(int rows, int cols)
            {
                char[,] alf = new char[rows, cols];
                Random rnd = new Random();
                string rusalf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        alf[i, j] = rusalf[rnd.Next(rusalf.Length)];
                    }
                }
                return alf;
            }
        /// <summary>
        /// Выводит массив
        /// </summary>
        /// <param name="alf"></param>
            public static void PrintArray(char[,] alf)
            {
                for (int i = 0; i < alf.GetLength(0); i++)
                {
                    for (int j = 0; j < alf.GetLength(1); j++)
                    {
                        Console.Write(alf[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        
    }
}
