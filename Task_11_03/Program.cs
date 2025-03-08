using System.Reflection.Metadata;

namespace Task_11_03
{
    internal class Program
    //Выходной параметр (out): Напишите метод, который принимает строку и возвращает через выходной параметр количество гласных и согласных букв в этой строке
    {
        public static void Main(string[] args)
        {
            int vowelsCount, consonantsCount;
            VowelConsonantCounter("Съешь ещё этих мягких французских булок, да выпей же чаю", out vowelsCount, out consonantsCount);
            Console.WriteLine("Гласных в массиве: " + vowelsCount);
            Console.WriteLine("Согласных в массиве: " + consonantsCount);
        }
        /// <summary>
        /// считает количество гласных и согласных в строке
        /// </summary>
        /// <param name="text"></param>
        /// <param name="vowelsCount"></param>
        /// <param name="consonantsCount"></param>
        public static void VowelConsonantCounter(string text, out int vowelsCount, out int consonantsCount)
        {
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            text = text.ToLower();
            vowelsCount = 0;
            consonantsCount = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if (Array.IndexOf(vowels, c) != -1)
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantsCount++;
                    }
                }
            }
        }
    }
}