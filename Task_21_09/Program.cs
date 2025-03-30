namespace Task_21_09
{
    internal class Program
    {
        /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов*/
        static void Main(string[] args)
        {
            List<Ticket> tickets = new List<Ticket>();
            Random random = new Random();
            for (int i = 1; i <= 30; i++)
            {
                double price = random.NextDouble() * 500 + 50;
                bool baggage = random.Next(2) == 0;
                bool discount = random.Next(2) == 0;
                tickets.Add(new Ticket(i, price, baggage, discount));
            }
            Console.WriteLine("Все билеты:");
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket);
            }
            Ticket maxTicket = null;
            foreach (Ticket ticket in tickets)
            {
                if (maxTicket == null || ticket.Price > maxTicket.Price)
                {
                    maxTicket = ticket;
                }
            }
            Console.WriteLine($"\nБилет с максимальной суммой: {maxTicket}");
            Ticket minTicket = null;
            foreach (Ticket ticket in tickets)
            {
                if (minTicket == null || ticket.Price < minTicket.Price)
                {
                    minTicket = ticket;
                }
            }
            Console.WriteLine($"Билет с минимальной суммой: {minTicket}");
            Console.WriteLine("\nБилеты с багажом:");
            foreach (Ticket ticket in tickets)
            {
                if (ticket.HasBaggage)
                {
                    Console.WriteLine(ticket);
                }
            }
            Console.WriteLine("\nЛьготные билеты:");
            foreach (Ticket ticket in tickets)
            {
                if (ticket.IsDiscounted)
                {
                    Console.WriteLine(ticket);
                }
            }
        }
    }
}
