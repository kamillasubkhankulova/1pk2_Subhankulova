namespace Task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car ("A123BC", "Toyota", "Blue", 50 );
            myCar.boostCar(50);
            myCar.boostCar(30);
            myCar.Brake(70);
            myCar.Brake(100);
        }
    }
}
