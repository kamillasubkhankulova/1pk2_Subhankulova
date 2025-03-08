namespace Task_11_05
{
    internal class Program
        //Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и возвращает их сумму и произведение через выходные параметры(out).
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y =10;
            int sumResult;
            int productResult;
            Console.WriteLine($"До вызова метода: x = {x}, y = {y}");
            CalculateSumAndProduct(ref x, ref y, out sumResult, out productResult);
            Console.WriteLine($"После вызова метода: x = {x}, y = {y}, sum = {sumResult}, product = {productResult}");
        }
        /// <summary>
        ///  возвращает их сумму и произведение через выходные параметры 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        /// <param name="product"></param>
        public static void CalculateSumAndProduct(ref int a, ref int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
            a = a * 2;
            b = b * 2;
            Console.WriteLine($"Внутри метода a={a}, b={b}");
        }
    }
}
