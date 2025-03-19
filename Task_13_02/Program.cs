namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("Барсик", "Кот", 3, 4.5, true);
            Pet pet2 = new Pet("Шарик", "Собака", 5, 15.0, false);
            pet1.GetInfo();
            pet2.GetInfo();
            pet1.ChangeWeight(5.0);
            pet1.ChangeHealth(false);
            pet1.GetInfo();
        }
    }
}
