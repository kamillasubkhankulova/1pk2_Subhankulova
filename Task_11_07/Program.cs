namespace Task_11_07
{
    internal class Program
    //Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода.
    {
        static void Main(string[] args)
        {
            int[] Mass = { 1, 2, 3, 4, 5 };
            Console.WriteLine("До вызова метода: ");
            PrintArray(Mass);
            IncrementArrayElements(ref Mass);
            Console.WriteLine("После вызова метода: ");
            PrintArray(Mass);
        }
        /// <summary>
        /// увеличивает каждый элемент в массие на 1 единицу
        /// </summary>
        /// <param name="arr"></param>
        public static void IncrementArrayElements(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
            Console.WriteLine("Внутри метода: ");
            PrintArray(arr);
        }
        /// <summary>
        /// Выводит массив
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
