using MenuShell.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace MenuShell.Domain
//{
//    class UserLoader : IUserService
//    {
//        public static void GetUsers()
//        {
//            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

//            string queryString = "SELECT * FROM User";

//            using (var connection = new SqlConnection(connectionString))
//            {
//                var SqlCommand = new SqlCommand(queryString, connection);

//                try
//                {
//                    connection.Open();

//                    var reader = SqlCommand.ExecuteReader();
                    
//                    while (reader.Read())
//                    {
//                        Console.WriteLine($"{reader[0]} ,{reader[1]} ,{reader[2]} ");
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e);
//                    throw;
//                }
//            }
//        }
        
//        public List<User> LoadUsers()
//        {
//            //var johnDoe = new User("John", "Secret", "Receptionist");
//            //var janeDoe = new User("Jane", "Secret", "Vetrinarian");
//            //var admin = new User("Admin", "Admin", "Admin");

//            var users = new List<User>();

//            //users.Add(johnDoe);
//            //users.Add(janeDoe);
//            //users.Add(admin);

//            return users;

//            //var doc = XDocument.Load("Users.xml");

//            //var root = doc.Root;

//            //foreach (var element in root.Elements())
//            //{
//            //    var username = element.Attribute("username").Value;
//            //    var password = element.Attribute("password").Value;
//            //    var role = element.Attribute("role").Value;

//            //    users.Add(new User(username, password, role));
//            //}
//            //return users;
//        }
//    }
//}
