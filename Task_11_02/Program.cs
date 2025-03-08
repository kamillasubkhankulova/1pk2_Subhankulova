namespace Task_11_02
{
    internal class Program
    //Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и меняет их местами.Проверьте, изменились ли значения переменных вне метода
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"До вызова метода: x={x}, y={y}");
            Revers(ref x, ref y);
            Console.WriteLine($"После вызова метода: x={x}, y={y}");
        }
        /// <summary>
        /// переворачивает значения, которые были заданы
        /// </summary>
        /// <param переменная="a"></param>
        /// <param переменная="b"></param>
        public static void Revers(ref int a, ref int b)
        {
            int n = a;
            a = b;
            b = n;
            Console.WriteLine($"Внутри метода: {a}, {b}");
        }
        
    }
}
