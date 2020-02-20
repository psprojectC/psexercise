using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestUser
    {
        public TestUser(String s)
        {
            name = s;
        }
        public String name
        { get; set; }

        private static User _testUser;
        public static void ResetTestUserData(User u)
        {
            _testUser = u;
        }

        public override string ToString()
        {
            return "{" + this.name + "}\n";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        static public User testUser
        {
            get {
                ResetTestUserData(null);
                return _testUser;
            }
            set { }
        }

    }
}
