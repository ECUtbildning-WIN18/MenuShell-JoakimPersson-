using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class MangeUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            var register = new RegisterNewUser();

            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Delete user");
            string menuChoise = Console.ReadLine();

            switch (menuChoise)
            {
                case "1":
                    {
                        register.Display();
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                default:
                    break;
            }

            return "";
        }
    }
}
