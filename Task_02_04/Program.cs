using System.Data;
using System.Numerics;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об этом.
            
            Console.WriteLine("\nВведите свой год рождения: \n");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите свой месяц рождения: \n");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите дату рождения: \n");
            int day = int.Parse(Console.ReadLine()); //ввожу три переменных, которые будут отвечать за дату рождения пользователя.
            var today = DateTime.Today; //ввожу переменную today, которая будет отвечать за настоящую дату
            DateTime birthday = new DateTime(year, month, day);
            int age = today.Year - birthday.Year; 
            {
                if (birthday > today.AddYears(-age)) age--; //если дата рождения больше чем нынешняя дата, то вычитается один год
                if (age < 18)
                    Console.WriteLine("\nПользователь не совершеннолетнй: \n");
                else
                    Console.WriteLine("\nПользователь совершеннолетний\n");
            }

        }
    }
}