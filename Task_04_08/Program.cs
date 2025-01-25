namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения которых равны.
            int[] number = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 101);
                Console.Write(" "+number[i]+" ");
            }
            int couple = 0;
            for (int i = 0;i < number.Length; i++)
            {
                for(int j = 0; j<i;  j++) if( number[i] == number[j]) couple++;
             
            }
            Console.WriteLine($"Количество пар - {couple}");
            
            Console.ReadKey();
            
        }
    }
}
