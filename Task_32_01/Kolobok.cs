using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }
        public int WindSpeed { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
            WindSpeed = 0;
        }
        //я добавила препятствие в виде ветра, если он будет превышать 15 м.с, то колобка сдувает.если > 6, то он тормозит
        public void Roll()
        {
            Random rnd = new Random();
            int windChange = rnd.Next(-5, 10);
            WindSpeed += windChange;
            if (WindSpeed > 15)
            {
                IsAlive = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Колобка сдуло сильным ветром! Game over!!  ({WindSpeed} м/с)");
                Console.ResetColor();
                return;
            }
            else if (WindSpeed < 0)
            {
                WindSpeed = 0;
            }
            if (WindSpeed > 6)
            {
                int obstacleDelay = rnd.Next(1, 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Колобка сдувает ветром. Он замедлился на {obstacleDelay} секунды.");
                Console.ResetColor();
                for (int i = 0; i < obstacleDelay; i++)
                {
                    Console.WriteLine($"Колобок стоит на месте из-за ветра ({i + 1} из {obstacleDelay})");
                }
            }
            Console.WriteLine($"Скорость ветра: {WindSpeed} м/с");
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
    }
}
