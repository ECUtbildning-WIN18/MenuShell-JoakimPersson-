using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class AuthentificationService : IAuthentificationService
    {
        private readonly IList<User> _users;

        public AuthentificationService(IList<User> users)
        {
            _users = users;
        }

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

    }
}
