namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в результирующий массив) Вывести результирующий массив
            int[,] mass1 = new int[10, 10];
            int[,] mass2 = new int[10, 10];
            Random random = new Random();
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass1[i, j] = random.Next(1, 10);
                    Console.Write(mass1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nВторой массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass2[i, j] = random.Next(1, 10);
                    Console.Write(mass2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] mass3 = new int[10, 10];
            Console.WriteLine("\nРезультирующий массив (произведение двух массивов):");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass3[i, j] = mass1[i, j] * mass2[i, j];
                    Console.Write(mass3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}