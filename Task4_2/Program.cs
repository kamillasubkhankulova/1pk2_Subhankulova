using System.Data;
using System.Numerics;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите свой год рождения: \n");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите свой месяц рождения: \n");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите дату рождения: \n");
            int day = int.Parse(Console.ReadLine());
            var today = DateTime.Today;
            DateTime birthday = new DateTime(year, month, day);
            int age = today.Year - birthday.Year;
            {
                if (birthday > today.AddYears(-age)) age--;
                if (age < 18)
                    Console.WriteLine("\nПользователь не совершеннолетнй: \n");
                else
                    Console.WriteLine("\nПользователь совершеннолетний\n");
            }

        }
    }
}