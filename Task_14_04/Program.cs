namespace Task_14_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Камилла", Email = "kamillasubhankulova38@gmail.com" };
            User.SetCurrentUser(user1);

            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}, Email: {User.CurrentUser.Email}");
        }
    }
}
