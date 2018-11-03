using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class AdminMainView : ConsoleView
    {
        private readonly IList<User> _users;

        public AdminMainView(IList<User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            var manageUser = new ManageUserView(_users);
            var loginView = new LoginView();
            base.Display();
            
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("1. Manage users");
                Console.WriteLine("2. Exit");
                string menuChoise = Console.ReadLine();
                
                if (menuChoise == "1")
                {
                    manageUser.Display();
                }
                else if (menuChoise == "2")
                {
                    menu = false;
                }
                else
                {
                    Console.WriteLine("Select number between 1-2");
                }
            }

            return "";
        }
    }
}
