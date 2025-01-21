using System.Runtime.Serialization.Formatters;

namespace Task_08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 20; n <= 50; n++)
            {
                if (n % 3 == 0 & n % 5 != 0)
                {
                    Console.WriteLine(n);
                }
            }


        }
    }
}
