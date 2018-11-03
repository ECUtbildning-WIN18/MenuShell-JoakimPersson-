using MenuShell.Domain;
using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuShell
{
    class Program
    {
        private readonly IList<User> _users;

        public Program(IList<User> users)
        {
            _users = users;
        }

        static void Main(string[] args)
        {
            var userLoader = new SqlUserService();
            var users = userLoader.GetUsers();

            var receptionistView = new ReceptionistMainView();

            var adminView = new AdminMainView(users);

            bool menu = true;
            while (menu)
            {
                Console.Write("Username: ");
                var userName = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? [Y]es [N]o");
                var consolekeyInfo = Console.ReadKey();
                if (consolekeyInfo.Key == ConsoleKey.Y)
                {
                    var authenticationService = new AuthentificationService(users);

                    var user = authenticationService.Authenticate(userName, password);

                    if (user != null)
                    {
                        Console.WriteLine("\nSuccesfully logged in");

                        Thread.Sleep(2000);

                        Console.WriteLine($"Role {user.Role}");
                        if (user.Role == "Receptionist")
                        {
                            receptionistView.Display();
                        }
                        if (user.Role == "Administrator")
                        {
                            adminView.Display();
                        }
                        if (user.Role == "Vetrinarian")
                        {

                        }
                    }

                    else
                    {
                        Console.WriteLine("\nAccess denied!");
                    }
                }
            }
        }
    }
}
