using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuShell.Domain
{
    class SqlUserService
    {
        public List<User> ShowUser(string username)
        {
            var users = new List<User>();

            using (var context = new MenuShellDbContext())
            {
                return context.Users.ToList();
            }

        }

        //public ShowUser(string username)
        //{
        //    var users = new List<User>();
        //    using (var context = new MenuShellDbContext())
        //    {
        //        return context.Users.ToList();
        //    }

        //}

        public List<User> GetUsers()
        {
            var users = new List<User>();

            using (var context = new MenuShellDbContext())
            {
                return context.Users.ToList();
            }

        }

        public void CreateUser(User user)
        {
            using (var context = new MenuShellDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void DeleteUser(string username)
        {
            using (var context = new MenuShellDbContext())
            {
                var foundCustomer = context.Users.FirstOrDefault(x => x.UserName == username);

                if (foundCustomer == null) return;

                context.Users.Remove(foundCustomer);
                context.SaveChanges();
            }
        }
    }
}

