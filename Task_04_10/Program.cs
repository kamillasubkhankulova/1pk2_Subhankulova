namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array использовать нельзя.
            int[] num=new int[10];
            Random rnd=new Random();
            for(int i = 0; i < num.Length; i++)
            {
                num[i]=rnd.Next(-10,11);
                Console.Write("  "+ num[i]);

            }
            int rever = num.Length / 2;
            for(int i = 0;i < rever/2; i++)
            {
                int temp=num[i];
                num[i] = num[rever - 1 - i];
                num[rever - 1 - i] = temp;
            }
            for(int i = 0; i<(num.Length-rever)/2;i++)
            {
                int temp = num[rever + i];
                num[rever + i] = num[num.Length - 1 - i];
                num[num.Length - 1 - i] = temp;

            }
            Console.WriteLine($" Массив после реверса: [" + string.Join(", ", num) + "]");


        }
    }
}   
