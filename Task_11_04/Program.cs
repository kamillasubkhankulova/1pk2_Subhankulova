namespace Task_11_04
{
    internal class Program
    {
        //Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает их среднее значение.Используйте ключевое слово params
        static void Main(string[] args)
        {
            double average1 = TheAverageNumber(10, 20, 30, 40, 50);
            Console.WriteLine($"Среднее значение: {average1}");
        }
        /// <summary>
        /// Находит среднее значение чисел в массиве
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double TheAverageNumber(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
        
    }
}
