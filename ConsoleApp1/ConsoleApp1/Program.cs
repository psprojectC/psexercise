using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation l = new LoginValidation();
            l.ValidateUserInput(UserLogin.UserRoles.ADMIN);
            TestUser t = new TestUser("asdasdasdasd");
            Console.WriteLine(t.ToString());
        }
    }
}
