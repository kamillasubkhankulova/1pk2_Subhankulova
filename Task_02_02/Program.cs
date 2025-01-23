using System.Data;
using System.Numerics;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Найти значение выражения при a=8, b=14, c=Math.Pi/4
            double a = 8;
            double b = 14;
            double c = Math.PI / 4; //ввела три переменных со значениями.
            double numerator = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3), 0.25); //отдельно вычисляю числитель
            double denominator = (Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c))); //отдельно вычисляю знаменатель
            if (denominator != 0) //ввожу условие, что если числитель будет отличен от 0, тогда вывожу результат деления чисоителя и знаменателя. В противном случае, выдаю ошибку.
            {
                double result = numerator / denominator;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Знаменатель равен 0! Ошибка");
            }
            

        }
    }
}