namespace Task_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string user;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите текст (введите 'exit' или оставьте пустую строку для выхода):");
                user = Console.ReadLine();

                if (user == "exit" || string.IsNullOrEmpty(user))
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
