namespace Task_11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int[] mass = {x, y};
            Console.WriteLine($"До вызова метода: x={x}, y={y}");
            ReversNum(mass);
            Console.WriteLine($"После вызова метода: x={x}, y={y} ");
            Console.WriteLine($"После вызова метода {mass[0]}, {mass[1]}");
        }
        /// <summary>
        /// переворачивает значения массива
        /// </summary>
        /// <param name="mass"></param>
        public static void ReversNum(int[] mass)
        {
            int n = mass[0];
            mass[0] = mass[1];
            mass[1] = n;
            Console.WriteLine($"Внутри метода: {mass[0]}, {mass[1]}");
        }
    }
}
