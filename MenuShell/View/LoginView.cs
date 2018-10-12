using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class LoginView : ConsoleView
    {


        public override string Display()
        {
            bool loginSucceeded = false;
            do
            {
                base.Display();

                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                string userName = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("\nIs this correct? [Y]es [N]o");

                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (userName == "john" && password == "secret")
                    {
                        loginSucceeded = true;
                    }
                    else
                    {
                        Console.WriteLine("\nWrong password. Please try again");
                        Thread.Sleep(2000);
                    }
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("\nvalid selection");
                    Thread.Sleep(2000);
                }
            }
            while (!loginSucceeded);

            return "";
        }
    }
}
