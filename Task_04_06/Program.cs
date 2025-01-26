namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа помодулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть двух равных по модулю.В полученном массиве найти наибольшее по модулю число.
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] mass = new int[size];
            Random random = new Random();
            bool[] modulusCheck = new bool[size * 2];

            int count = 0;

            while (count < size)
            {
                int randomNum = random.Next(-size, size + 1); 
                if (randomNum != 0 && !modulusCheck[Math.Abs(randomNum)])
                {
                    mass[count] = randomNum;
                    modulusCheck[Math.Abs(randomNum)] = true; 
                    count++;
                }
            }

            int maxModulus = mass[0];
            for (int i = 1; i < size; i++)
            {
                if (Math.Abs(mass[i]) > Math.Abs(maxModulus))
                {
                    maxModulus = mass[i];
                }
            }

            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Наибольшее число по модулю: " + maxModulus);
        }
    }


}
    

