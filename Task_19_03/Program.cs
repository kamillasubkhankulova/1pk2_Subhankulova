using System.Reflection.Metadata;

namespace Task_19_03
{
    internal class Program
    {
        /*Напишите консольное приложение, в котором осуществляется построчный пользовательский
ввод (ввод каждой строки подтверждается нажатием на enter). количество введенных строк
произвольно, ввод завершается при вводе пустой строки.
После окончания ввода произведите объединение всех ранеее введенных строк в одну с
использованием разделителя «-» */
        static void Main(string[] args)
        {
            string linecom = "";
            string line;
            int linenum = 1;
            do
            {
                Console.Write($"Введите строку {linenum++}: ");
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    linecom += (linecom.Length > 0 ? "-" : "") + line;
                }
            } while (!string.IsNullOrEmpty(line));
            Console.WriteLine("Результат: " + linecom);
            Console.ReadKey();
        }
    }
}
