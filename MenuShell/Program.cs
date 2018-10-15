using MenuShell.Domain;
using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var receptionistView = new ReceptionistMainView();
            var adminView = new AdminMainView();

            Console.Write("Username: ");
            var userName = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            var authenticationService = new AuthentificationService();

            var user = authenticationService.Authenticate(userName, password);

            if (user != null)
            {
                Console.WriteLine("Succesfully logged in");

                Console.WriteLine($"Role {user.Role}");
                if (user.Role == "Receptionist")
                {
                    receptionistView.Display();
                }
                if(user.Role == "Admin")
                {
                    adminView.Display();
                }
                if (user.Role == "Vetrinarian")
                {

                }

            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}
