using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    internal class Access
    {
        private AccessLevel nowLevel;
        public Access()
        {
            nowLevel = AccessLevel.Guest;
        }
        //создаем переменную, которая будет отобращать наш статус
        public void SetLevel(AccessLevel level)
        {
            nowLevel=level;
        }
        //проверяем нынешний статус подходит для нужной команды или он ниже
        public bool CheckLevel(AccessLevel needLevel)
        {
            return nowLevel==AccessLevel.Admin||(int)nowLevel >= (int)needLevel;
        }
        //создаем метод, который удаляет посты с сайта и проверяем достаточно ли прав
        public void ResetPost()
        {
            if(CheckLevel(AccessLevel.Moderator))
            {
                Console.WriteLine("Пост был удален с сайта");
            }
            else
            {
                Console.WriteLine("Недостаточно прав!");
            }
        }
       //тоже саамое, только для добавления комментариев
        public void AddCom()
        {
            if(CheckLevel(AccessLevel.User))
            {
                Console.WriteLine("Ваш комментарий на сайте");
            }
            else
            {
                Console.WriteLine("Недостаточно прав!");
            }
        }
        public void ReadCon()
        {
            if(CheckLevel(AccessLevel.User))
            {
                Console.WriteLine("Вы прочитали контект");
            }
        }
        
    }
}
