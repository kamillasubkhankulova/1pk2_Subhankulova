using System;
using System.Drawing;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общееколичество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц иотдельно вывести дни без осадков.Массив с осадками  заполнятся с помощью рандома в диапазоне от 0 – нет осадков, до 300 мм выпавших осадков.
            Console.WriteLine("Осадки за каждый день месяца: ");
            int[] precipitation = new int[30];
            Random rnd = new Random();
            for (int i = 0; i < precipitation.Length; i++)

            {
                precipitation[i] = rnd.Next(0, 301); // для наглядности вывеоа все значения
                Console.Write(" " + precipitation[i]);
            }
            int summ1 = 0;
            for (int i = 0; i < 10; i++)
                summ1 = summ1 + precipitation[i]; // вывожу значения за 1 декаду, взяв первые 10 значений
            Console.WriteLine($"\n Сумма осадков за 1 декаду месяца : {summ1}");
            int summ2 = 0;
            for (int i = 10; i < 20; i++)
                summ2 = summ2 + precipitation[i]; // вывожу значения за 2 декаду, взяв значения с 10 -20
            Console.WriteLine($"\n Сумма осадков за 2 декаду месяца : {summ2}");
            int summ3 = 0;
            for (int i = 20; i < 30; i++)
                summ3 = summ3 + precipitation[i]; // вывожу значения за 3 декаду, взяв значения с 20 -30
            Console.WriteLine($"\n Сумма осадков за 3 декаду месяца : {summ3}");
            
            int max = precipitation.Max();
            for (int i = 0; i < precipitation.Length; i++)
            {
                if (precipitation[i] == max)
                    Console.WriteLine($"Максимальное количество осадков:{max} в этот день -  {i + 1}");
            }
            Console.WriteLine("Дни без осадков: ");
            for (int i = 0; i < precipitation.Length; i++)
            {
                if(precipitation[i] ==0)
                {
                    Console.WriteLine($"День без осадков {i + 1}");
                }
            }

            




        }
    }
}
