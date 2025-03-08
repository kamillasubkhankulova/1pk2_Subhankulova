namespace Task_11_06
{
    internal class Program
    {
        //Передача массива по значению: Напишите метод, который принимает массив целых чисел и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода
        static void Main(string[] args)
        {
            int[] Mass = { 1, 2, 3, 4, 5 };
            Console.WriteLine("До вызова метода: ");
            PrintArray(Mass);
            IncreaseByOne(Mass);
            Console.WriteLine("После вызова метода: ");
            PrintArray(Mass);
        }
        /// <summary>
        /// Добавляет к ккаждому жлементу в массиве +1
        /// </summary>
        /// <param name="array"></param>
        public static void IncreaseByOne(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
            Console.WriteLine("Внутри метода");
        }
        /// <summary>
        /// выводит массив
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

    }
}
