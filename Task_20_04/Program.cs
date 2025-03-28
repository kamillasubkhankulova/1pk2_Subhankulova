﻿using static Task_20_04.VehicleType;

namespace Task_20_04
{
    internal class Program
    {
        /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
     • Car
     • Bike
     • Bus
     • Truck
     • Motorcycle
       Храните список транспортных средств (можно просто List<VehicleType>).
       Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
       Реализуйте поиск по типу и вывод информации.*/
        static void Main(string[] args)
        {
            VehicleManage manager = new VehicleManage();
            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Truck);
            manager.AddVehicle(VehicleType.Bus);
            manager.AddVehicle(VehicleType.Bus);
            manager.AddVehicle(VehicleType.Truck);
            manager.AddVehicle(VehicleType.Motorcycle);
            manager.PrintCounts();
            manager.PrintType(VehicleType.Truck);
            manager.PrintType(VehicleType.Bike);
        }
    }
}
