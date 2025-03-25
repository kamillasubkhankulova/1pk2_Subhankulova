namespace Task_19_02
{
    internal class Program
    {
        /*Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий предложения(есть знаки препинания). программу после анализа выводит текст, разделенный на части:
a)
По пробелам(отдельные слова построчно)
b)
По предложениям(отдельные предложения построчно) (используйте метод Split()) */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст, содержащий предложения:");
            string Text1=Console.ReadLine();
            string[] Text2 = Text1.Split();
            foreach (string s in Text2)
            {
                Console.WriteLine(s);
            }
            string[] Text3 = Text1.Split('.', '!', '?');
            foreach (string predloz in Text3)
            {
                Console.WriteLine(predloz);
            }
            Console.ReadLine();
        }
    }
}
