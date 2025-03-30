namespace Task_21_08
{
    internal class Program
    {
        //напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки
        static void Main(string[] args)
        {
            string[] inputArray = { "red", "green", "blue", "red", "green" };
            string[] unique3 = Dictionary.GetStrings(inputArray);
            PrintStrings(unique3);
            static void PrintStrings(string[] strings)
            {
                foreach (string str in strings)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
