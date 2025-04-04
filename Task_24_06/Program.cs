using System.Security.Cryptography.X509Certificates;

namespace Task_24_06
{
    internal class Program
    {
        //Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. ИспользуйтеStreamReader
        static void Main(string[] args)
        {
            string Path = @"C:\Proga\ProgaFile.txt";
            int lines = CountLines(Path);
            if (lines != -1)
            {
                Console.WriteLine($"Количество строк: {lines}");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Подсчет количества строк в файле
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static int CountLines(string Path)
        {
            int lineCount = 0;
            if (File.Exists(Path))
            {
                using (StreamReader reader = new StreamReader(Path))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл {Path} не найден.");
                return -1;
            }
            return lineCount;
        }
    }
}
