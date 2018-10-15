using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class AdminMainView : ConsoleView
    {
        public override string Display()
        {
            var loginView = new LoginView();
            var manageUser = new MangeUserView();
            base.Display();

            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Exit");
            string menuChoise = Console.ReadLine();

            if (menuChoise == "1")
            {
                manageUser.Display();
            }
            else if (menuChoise == "2")
            {
                loginView.Display();
            }
            else
            {

            }
            return "";
        }
    }
}
