using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    internal class Car
    {
        #region Свойства
        public string Number { get; set; }
        public string Brand { get; set; }
        public string Colors { get; set; }
        public double Speed { get; set; }
        #endregion

        #region Конструктор
        public Car(string number, string brand, string colors, double speed)
        {
            Number = number;
            Brand = brand;
            Colors = colors;
            Speed = speed;
        }
        #endregion
        #region Метод
        public void boostCar(double acceleration)
        {
            Speed += acceleration;
        }
        public void Brake(int maxSpeed)
        {
            if (Speed > maxSpeed)
            {
                Speed = 0;
                Console.WriteLine($"Автомобиль остановился, превышена допустимая скорость! Текущая скорость: {Speed} км/ч.");
            }
            else
            {
                Console.WriteLine($"Автомобиль {Brand} тормозит. Текущая скорость: {Speed} км/ч.");
            }
            #endregion
        }
    }
}
