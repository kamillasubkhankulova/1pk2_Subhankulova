using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    internal class User
    {
        #region Свойство
        public static User CurrentUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        #endregion
        #region Метод
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }
        #endregion 
    }
}