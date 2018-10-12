using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class ReceptionistMainView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine("[1]Register new customer");
            Console.WriteLine("[2]Search for customer");
            Console.WriteLine("[3]Logout");

            var consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("D1");
                    return "1";
                case ConsoleKey.D2:
                    Console.WriteLine("D2");
                    return "2";
                case ConsoleKey.D3:
                    Console.WriteLine("D3");
                    return "3";
                default:
                    return "";
            }

        }
    }
}
