using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    /*Реализуйте автоматическое переключение цветов (каждые 3 секунды).
     При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep).
     Добавьте возможность ручного переключения (например, по нажатию клавиши).*/
    internal class TrafficActions
    {
        private TrafficLightColor nowColor;
        public TrafficActions()
        {
            nowColor = TrafficLightColor.Red;
        }
        private void PrintColor()
        {
            Console.WriteLine($"Текущий цвет: {nowColor}");
        }
        // Метод для переключения цветов
        public void RunAutomatic()
        {
            while (true)
            {
                PrintColor();
                Thread.Sleep(3000);
                switch (nowColor)
                {
                    case TrafficLightColor.Red:
                        nowColor = TrafficLightColor.Yellow;
                        break;
                    case TrafficLightColor.Yellow:
                        nowColor = TrafficLightColor.Green;
                        break;
                    case TrafficLightColor.Green:
                        nowColor = TrafficLightColor.Red;
                        break;
                }
            }
        }
        //ручное изменение цвета
        public void ManualChange()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (nowColor)
            {
                case TrafficLightColor.Red:
                    nowColor = TrafficLightColor.Yellow;
                    break;
                case TrafficLightColor.Yellow:
                    nowColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Green:
                    nowColor = TrafficLightColor.Red;
                    break;
            }
            PrintColor();
        }
    }
}
