using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class SearchUser : ConsoleView
    {
        private readonly IList<User> _users;

        public SearchUser(IList<User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            var manageUserView = new ManageUserView(_users);
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Search for username");
                Console.Write("Username: ");
                string nameSearch = Console.ReadLine();

                var searchResult = _users.Where(x => x.UserName.Contains(nameSearch)).ToList();


                foreach (var user2 in _users)
                {
                    if (user2.UserName.Contains(nameSearch))
                    {
                        Console.WriteLine(user2.UserName);
                    }

                }
                Console.Clear();

                Console.WriteLine("Search results");
                foreach (var userSearch in searchResult)
                {
                    Console.WriteLine(userSearch.UserName);
                }

                Console.Write("Delete>: ");
                string userToDelete = Console.ReadLine();



                var user = searchResult.FirstOrDefault(x => x.UserName == userToDelete);

                Console.WriteLine($"Delete user {user.UserName}? (Y)es (N)o ");
                var consolekeyInfo = Console.ReadKey();

                if (consolekeyInfo.Key == ConsoleKey.Y)
                {
                    _users.Remove(user);
                    manageUserView.Display();
                }
                else
                {
                    break;
                }


                //if ()
                //{
                //    Console.WriteLine($"Delete user {user.UserName}? (Y)es (N)o ");
                //    var consolekeyInfo = Console.ReadKey();
                //    if (consolekeyInfo.Key == ConsoleKey.Y)
                //    {
                //        _users.Remove(user);
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}

            }

            return base.Display();


        }
    }
}
