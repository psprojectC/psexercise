using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LoginValidation
    {
        public static UserLogin.UserRoles roles
        { get; private set; }
        public bool ValidateUserInput(UserLogin.UserRoles role)
        {
            roles = role;
            Console.WriteLine(role);
            return true;
        }
    }
}
