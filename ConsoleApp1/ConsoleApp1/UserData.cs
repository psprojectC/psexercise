using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace ConsoleApp1
{
    static class UserData
    {
        private static User[] _testUser;
        public static User[] TestUser
        {
            get
            {
                DefaultUserData();
                return _testUser;
            }
            set {}
        }
        static private void DefaultUserData()
        {
            _testUser = new User[5];
            _testUser[0] = new User("asdasd", "asdasd", "123123", (Int16) UserRoles.ADMIN);
            _testUser[1] = new User("asdasdasd1", "asdasdasd1", "1231231", (Int16)UserRoles.STUDENT);
            _testUser[2] = new User("asdasdasd2", "asdasdasd2", "12312312", (Int16)UserRoles.STUDENT);
            _testUser[3] = new User("asdasdasd3", "asdasdasd3", "123123123", (Int16)UserRoles.STUDENT);
            _testUser[4] = new User("asdasdasd4", "asdasdasd4", "1231231234", (Int16)UserRoles.STUDENT);
        }
    }
}
