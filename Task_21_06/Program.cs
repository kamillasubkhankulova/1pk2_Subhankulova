namespace Task_21_06
{
    internal class Program
    {
        //Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 4, 5, 1 };
            List<int> uniqueNumbers = List.Remove(numbers);
            Console.WriteLine("Исходный список:");
            PrintList(numbers);
            Console.WriteLine("Список без дубликатов:");
            PrintList(uniqueNumbers);
            static void PrintList(List<int> list)
            {
                foreach (int item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
