namespace Task_21_10
{
    internal class Program
    {
        //Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их значения.
        static void Main(string[] args)
        {
            Dictionary<string, int> dictA = new Dictionary<string, int>()
        {
            {"IT", 1},
            {"PI", 2},
            {"MATH", 3}
        };

            Dictionary<string, int> dictB = new Dictionary<string, int>()
        {
            {"IT", 4},
            {"BIOLOGY", 5},
            {"ALGEBRA", 6}
        };

            Dictionary<string, int> merged = Dictionary.MergeDictionaries(dictA, dictB);


            Console.WriteLine("Объединенный словарь:");
            PrintDictionary(merged);
        }
        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (var el in dict)
            {
                Console.Write($"{el.Key}: {el.Value}, ");
            }
            Console.WriteLine();
        }
    }
}
