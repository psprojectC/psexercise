using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserData
    {
        public static TestUser reff;
        static private void ResetUserData()
        {
            LoginValidation login = new LoginValidation();
            if (login.ValidateUserInput(UserLogin.UserRoles.ADMIN) && reff == null)
            {
                Console.WriteLine("asdasdasdasdasdasd");
            }
        }
    }
}
