namespace Task_24_08
{
    internal class Program
    {
        //реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователем
        static void Main(string[] args)
        {
            string filePath = @"C:\Proga\ProgaFile.txt";
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();
            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();
            FindWord(filePath, searchText, replaceText);
            Console.ReadKey();
        }
        public static void FindWord(string filePath, string searchText, string replaceText)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден.");
                return;
            }
            string originalText;
            using (StreamReader reader = new StreamReader(filePath))
            {
                originalText = reader.ReadToEnd();
            }
            string newText = originalText.Replace(searchText, replaceText);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(newText);
            }
            Console.WriteLine("Текст успешно заменен.");
        }
    }
}

