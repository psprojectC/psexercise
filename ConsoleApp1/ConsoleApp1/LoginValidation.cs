using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace ConsoleApp1
{
    class LoginValidation
    {
        private string userName;

        private string GetUserName()
        {
            return userName;
        }

        private void SetUserName(string value)
        {
            userName = value;
        }

        private string password1;

        private string Getpassword()
        {
            return password1;
        }

        private void Setpassword(string value)
        {
            password1 = value;
        }

        private String Message
        { get; set; }

        public LoginValidation(string userName, string password)
        {
            this.SetUserName(userName);
            this.Setpassword(password);
        }

        public static UserRoles CurrentUserRole
        {
            get { return CurrentUserRole; }
            private set { }
        }
        public object ValidateUserInput(User u)
        {
            if (u.username.Length < 5 || u.password.Length < 5)
            {
                return false;
            }
            CurrentUserRole = (UserRoles)u.role;
            User temp = IsUserPassCorrect(u.username, u.password);
            if (temp != null)
            {
                CurrentUserRole = (UserRoles) temp.role;
                return true;
            }
            else
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                this.Message += "User not found.";
                return false;
            }
        }
        public static User IsUserPassCorrect(String name, String pass)
        {
            User ret = null;
            foreach(User u in UserData.TestUser)
            {
                if (!u.username.Equals(name) || !u.password.Equals(pass))
                {
                    return null;
                }
                ret = u;
            }
            Console.WriteLine(ret.ToString());
            return ret;
        }
    }
}
