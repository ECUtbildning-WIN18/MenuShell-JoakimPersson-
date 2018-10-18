using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class RegisterNewUser : ConsoleView
    {
        private readonly IList<User> _users;

        public RegisterNewUser(IList<User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            bool notSufficentInformation = true;

            do
            {
                base.Display();
                var adminMainView = new AdminMainView(_users);
                
                Console.WriteLine("Register user\n");
                Console.Write("Select username: ");
                string username = Console.ReadLine();

                Console.Write("Select password: ");
                string password = Console.ReadLine();

                Console.Write("Select role: ");
                string role = Console.ReadLine();

                Console.WriteLine("\nIs this correct? [Y]es [N]o");
                var consolekeyInfo = Console.ReadKey();

                if (consolekeyInfo.Key == ConsoleKey.Y)
                {
                    var user = new User(username, password, role);

                    _users.Add(user);

                    Console.Clear();
                    notSufficentInformation = false;
                }
                else
                {
                    adminMainView.Display();
                }

            } while (notSufficentInformation);

            return "";
        }
    }
}
