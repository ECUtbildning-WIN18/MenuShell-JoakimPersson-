using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class UserLoader : IUserLoader
    {
        public List<User> LoadUsers()
        {
            var registerNewUser = new RegisterNewUser();
            var johnDoe = new User("John", "Secret", "Receptionist");
            var janeDoe = new User("Jane", "Secret", "Vetrinarian");
            var admin = new User("Admin", "Admin", "Admin");
            var users = new List<User>();

            users.Add(johnDoe);
            users.Add(janeDoe);
            users.Add(admin);

            return users;

            //var doc = XDocument.Load("Users.xml");

            //var root = doc.Root;

            //foreach (var element in root.Elements())
            //{
            //    var username = element.Attribute("username").Value;
            //    var password = element.Attribute("password").Value;
            //    var role = element.Attribute("role").Value;

            //    users.Add(new User(username, password, role));
            //}
            //return users;
        }
    }
}
