namespace Task_24_07
{
    internal class Program
    {
        //Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки,
        //содержащие это слово (регистро независимо).
        static void Main(string[] args)
        {
            string filePath = @"C:\Proga\ProgaFile.txt";
            string searchWord = "Hi";

            List<string> foundLines = FindWord(filePath, searchWord);

            Console.WriteLine($"Строки, содержащие слово -{searchWord}- :");
            foreach (string line in foundLines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
        public static List<string> FindWord(string filePath, string searchWord)
        {
            List<string> matchingLines = new List<string>();
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchingLines.Add(line);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл {filePath} не найден.");
            }
            return matchingLines;
        }
    }
}
