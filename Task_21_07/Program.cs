namespace Task_21_07
{
    internal class Program
    {
        //Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. Еслизначениянет, вернуть null.
        static void Main(string[] args)
        {
            Dictionary<string, int> newDiction = new Dictionary<string, int>()
        {
            {"math", 1},
            {"PI", 2},
            {"Russian", 3},
            {"physics", 2}
        };
            string keyFor2 = Lib.FindFirstKey(newDiction, 2);
            Console.WriteLine($"Ключ для значения 2: {keyFor2}");
            string keyFor5 = Lib.FindFirstKey(newDiction, 5);
            Console.WriteLine($"Ключ для значения 5: {keyFor5}");
        }
    }
}
