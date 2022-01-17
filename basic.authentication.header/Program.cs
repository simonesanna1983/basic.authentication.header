using System;
using System.Text;

namespace basic.authentication.header
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username:");
            string userName = Console.ReadLine();


            Console.WriteLine("Password:");
            string password = Console.ReadLine();


            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(userName + ":" + password));

            Console.WriteLine();
            Console.WriteLine($"Basic {svcCredentials}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
