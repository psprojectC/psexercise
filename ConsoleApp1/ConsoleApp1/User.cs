using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public String username;
        public String password;
        public String fNum;
        public Int16 role;

        public User(string username, string password, string fNum, short role)
        {
            this.username = username;
            this.password = password;
            this.fNum = fNum;
            this.role = role;
        }

        public override string ToString()
        {
            return $"{{{this.username}, {this.password}, {this.fNum}, {this.role}}}\n";
        }
    }
}
