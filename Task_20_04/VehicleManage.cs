using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    internal class VehicleManage
    {
        private List<VehicleType> vehicles;
        public VehicleManage()
        {
            vehicles = new List<VehicleType>();
        }
        /// <summary>
        /// добавляет новый тип трансопрта
        /// </summary>
        /// <param name="type"></param>
        public void AddVehicle(VehicleType type)
        {
            vehicles.Add(type);
        }
        /// <summary>
        /// счетчик количества тс разных типов
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int CountVehicle(VehicleType type)
        {
            int count = 0;
            foreach( VehicleType vehicle in vehicles )
            {
                if (vehicle==type)
                {
                    count++;
                }
            }
            return count;
        }
        //создаем новый список, которых будет хранить наши найденные тс
        public List<VehicleType> SearchType(VehicleType type)
        {
            List<VehicleType>found=new List<VehicleType>();
            foreach(VehicleType vehicle in vehicles )
            {
                if (vehicle==type)
                { 
                    found.Add(vehicle);
                }
            }
            return found;
        }
        //просто метод, который в дальнейшем будет выводить количество тс
        public void PrintCounts()
        {
            Console.WriteLine("Количество транспортов по типу: ");
            foreach(VehicleType type in Enum.GetValues(typeof(VehicleType)))
            {
                int count=CountVehicle(type);
                Console.WriteLine($"{type}: {count}");
            }
        }
        //метод будет выводить типы тс
        public void PrintType(VehicleType type)
        {
            List<VehicleType> foundV=SearchType(type);
            if(foundV.Count>0)
            {
                Console.WriteLine($"Найденные тс типа {type}:");
                foreach(VehicleType vehicle in foundV)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine($"Тс этого типа {type} нету");
            }
        }
    }
}