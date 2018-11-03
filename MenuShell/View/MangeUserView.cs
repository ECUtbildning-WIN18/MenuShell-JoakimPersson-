﻿using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class ManageUserView : ConsoleView
    {
        private readonly IList<User> _users;

        public ManageUserView(IList<User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            var sqlUserService = new SqlUserService();
            base.Display();
            var register = new RegisterNewUser(_users);
            var searchUser = new SearchUser(_users);
            bool menu = true;
            while (menu)
            {
                
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Search user");
                Console.WriteLine("3. Delete user");
                Console.WriteLine("4. Exit");
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
                            searchUser.Display();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Type Username of user you want to delete.");
                            string name =  Console.ReadLine();

                            sqlUserService.DeleteUser(name);

                            break;
                        }
                    case "4":
                        {
                            menu = false;
                            break;
                        }
                    default:
                        break;
                }
            }
            return "";
        }
    }
}
