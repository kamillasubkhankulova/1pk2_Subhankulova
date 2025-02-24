﻿namespace Task_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда пользователь вводить слово «exit» или пустую строку - ввод останавливается и выводиться количество строк введенных пользователем.
            int count = 0; //количество строк приравниваем к нулю
            string user; // вводим переменную пользователь

            while (true) //создаем бесконечный цикл
            {
                Console.Clear();
                Console.WriteLine("Введите текст (введите 'exit' или оставьте пустую строку для выхода):");
                user = Console.ReadLine();

                if (user == "exit" || string.IsNullOrEmpty(user)) //если пользователь вводит выход или нулевое значение, тогда цикл останавливается, если ввод продолжается, то к количеству строк +1
                {
                    break;
                }

                count++;
            }

            Console.Clear();
            Console.WriteLine($"Количество введенных строк: {count}"); 
        }
    }
}
