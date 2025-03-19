using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        #region Свойство
        public string Nickname { get; set; }
        public string View { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool Health { get; set; }
        #endregion
        #region Конструктор
        public Pet(string nickname, string view, int age, double weight, bool health)
        {
            Nickname = nickname;
            View = view;
            Age = age;
            Weight = weight;
            Health = health;
        }
        #endregion
        #region Метод
        public void GetInfo()
        {
            Console.WriteLine($"Кличка животного: {Nickname}\n, Вид животного: {View}\n, Возраст животоного: {Age}\n, Вес животоного: {Weight}\n, Состояние здоровья: {Health}\n.");
        }
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
        }
        public void ChangeHealth(bool newHealth)
        {
            Health = newHealth;
        }
        #endregion
    }
}

