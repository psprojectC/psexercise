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
            String name, pass;
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Pass: ");
            pass = Console.ReadLine();
            LoginValidation login = new LoginValidation(name, pass);
            User ensure = new User(name, pass, "", (Int16) UserLogin.UserRoles.ADMIN);
            try
            {
                if (login.ValidateUserInput(ensure) != null)
                {
                    Console.WriteLine(LoginValidation.IsUserPassCorrect(name, pass).ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(UserData.TestUser[0].ToString());
                var sth = (UserLogin.UserRoles)UserData.TestUser[0].role;
                Console.WriteLine($"Role: {sth.ToString()}");
            }
        }
    }
}
