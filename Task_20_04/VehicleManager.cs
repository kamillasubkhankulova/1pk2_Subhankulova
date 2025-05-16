using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    internal class VehicleManager
    {
        private List<Vehicle> vehicles;
        public VehicleManager()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle type)
        {
            vehicles.Add(type);
        }

        public int CountVehiclesOfType(Vehicle type)
        {
            return vehicles.Count(v => v == type);
        }

        public List<Vehicle> SearchVehiclesOfType(Vehicle type)
        {
            return vehicles.Where(v => v == type).ToList();
        }
        public void PrintVehicleCounts()
        {
            Console.WriteLine("Количество транспортных средств по типам:");
            foreach (Vehicle type in Enum.GetValues(typeof(Vehicle)))
            {
                int count = CountVehiclesOfType(type);
                Console.WriteLine($"{type}: {count}");
            }
        }


        public void PrintVehiclesOfType(Vehicle type)
        {
            List<Vehicle> foundVehicles = SearchVehiclesOfType(type);
            if (foundVehicles.Count > 0)
            {
                Console.WriteLine($"Найденные транспортные средства типа {type}:");
                foreach (Vehicle vehicle in foundVehicles)
                {
                    Console.WriteLine(vehicle);
                }

            }
            else
            {
                Console.WriteLine($"Транспортные средства типа {type} не найдены.");
            }

        }
    }
}
