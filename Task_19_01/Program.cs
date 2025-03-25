namespace Task_19_01
{
    internal class Program
    {
        /*Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего
        программа запрашивает подстроку для поиска.Если подстрока найдена - то программа запрашивает
        текст для того чтобы заменить на него эту подстроку(столько раз, сколько раз подстрока встречена
        в тексте) Пример:Введите строку: "Привет, мир!" Введите подстроку для поиска: "мир" Введите подстроку для замены: "друг" Результат: "Привет, друг!" */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string Text1=Console.ReadLine();
            Console.WriteLine("Введите подстроку для поиска:");
            string Text2=Console.ReadLine();
            if(Text1.Contains(Text2))
            {
                Console.WriteLine("Введите подстроку для замены:");
                string Text3 = Console.ReadLine();
                string Text4 = Text1.Replace(Text2, Text3);
                Console.WriteLine("Результат: " + Text4);
            }
            else
            {
                Console.WriteLine("Такой подстрочки нет! ");
            }
            Console.ReadLine();
        }
    }
}
