using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов*/
    internal class Ticket
    #region Свойства
    {
        public int TicketNumber { get; set; }
        public double Price { get; set; }
        public bool HasBaggage { get; set; }
        public bool IsDiscounted { get; set; }
        #endregion
        #region Конструктор
        public Ticket(int ticketNumber, double price, bool hasBaggage, bool isDiscounted)
        {
            TicketNumber = ticketNumber;
            Price = price;
            HasBaggage = hasBaggage;
            IsDiscounted = isDiscounted;
        }
        #endregion
        #region Метод
        public override string ToString()
        {
            return $"Номер: {TicketNumber}, Цена: {Price}, Багаж: {(HasBaggage ? "Да" : "Нет")}, Льгота: {(IsDiscounted ? "Да" : "Нет")}";
        }
        #endregion
    }
}
