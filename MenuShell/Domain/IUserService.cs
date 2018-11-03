using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    interface IUserService
    {
        List<User> GetUsers();
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
