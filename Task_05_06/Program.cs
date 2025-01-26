namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Осуществить генерация двумерного [10*5] массива по следующему правилу:1 столбец содержит нули2 столбце содержит числа кратные 2 3 столбец содержит числа кратные 3 4 столбец содержит числа кратные 4 5 столбец содержит числа кратные 5 Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив

            int n = 10;
            int m = 5;
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                mass[i, 0] = 0;
                mass[i, 1] = (i + 1) * 2; 
                mass[i, 2] = (i + 1) * 3; 
                mass[i, 3] = (i + 1) * 4; 
                mass[i, 4] = (i + 1) * 5; 
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] rever = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rever[j, i] = mass[i, j];
                }
            }
            Console.WriteLine("\nНовый массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(rever[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
