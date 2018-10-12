using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class RegisterNewCustomer : ConsoleView
    {
        public override string Display()
        {
            bool notSufficentInformation = true;

            do
            {
                base.Display();

                Console.WriteLine("Register user\n");
                Console.Write("First name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Social security number: ");
                string socialSecurityNumber = Console.ReadLine();

                Console.WriteLine("\nIs this correct? [Y]es [N]o");
                var consolekeyInfo = Console.ReadKey();

                if (consolekeyInfo.Key == ConsoleKey.Y)
                {

                }
                else
                {

                }

            } while (notSufficentInformation);
            return "";
        }
    }
}
