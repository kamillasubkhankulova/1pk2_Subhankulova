using System.Security.Cryptography.X509Certificates;

namespace Task_20_05
{
    internal class Program
    {
        /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
      • Guest (только чтение)
      • User (чтение + комментарии)
      • Moderator (удаление контента)
      • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост)
        На основе уровня доступа выводите сообщение (например, "Ошибка: Недостаточно прав!").*/
        static void Main(string[] args)
        {
            Access user = new Access();
            user.SetLevel(AccessLevel.Guest);
            user.ReadCon();
            user.AddCom();
            user.ResetPost();

            user.SetLevel(AccessLevel.User);
            user.ReadCon();
            user.AddCom();
            user.ResetPost();

            user.SetLevel(AccessLevel.Moderator);
            user.ReadCon();
            user.AddCom();
            user.ResetPost();

            user.SetLevel(AccessLevel.Admin);
            user.ReadCon();
            user.AddCom();
            user.ResetPost();
        }
    }
}
