using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    class AuthentificationService : IAuthentificationService
    {
        private readonly IUserLoader _userLoader;

        public AuthentificationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            List<User> users = _userLoader.LoadUsers();


            return users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

    }
}
