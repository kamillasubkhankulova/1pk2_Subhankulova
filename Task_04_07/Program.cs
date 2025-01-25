using System;

namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для  мальчиков и девочек. При выводе избавиться от отрицательных значений.
            int[] child = new int[30];
            Random rnd=new Random();
            for (int i = 0; i < child.Length; i++)
            {
                child[i] = rnd.Next(-200,200); //рост всех детей
                Console.WriteLine("  "+ child[i]+ " ");
            }
            int boys =0;
            int girls = 0;
            
            for (int i = 0; i < child.Length; i++)
                
            {
                if(child[i] <0)
                {
                    boys++; 
                }
                if(child[i] > 0)
                {
                    girls++;
                }
                
            }
            
            Console.WriteLine($" Количество мальчиков  -  {boys}");
            Console.WriteLine($" Количество девочек -  {girls}");
            int sumboys = 0;
            int sumgirls = 0;
            for (int i = 0;i < child.Length;i++)
            {
                if (child[i] < 0)
                {
                    sumboys = sumboys + child[i]; //общий рост пацанчиков
                }
                if (child[i] > 0)
                {
                    sumgirls=sumgirls + child[i]; //общий рост девочек
                }
            }
            int averageboys = Math.Abs(sumboys / boys);
            int averagegirls= sumgirls / girls;
            Console.WriteLine($"Средний рост мальчиков-  {averageboys}");
            Console.WriteLine($"Средний рост девочек-  {averagegirls}");



        }
    }
}
