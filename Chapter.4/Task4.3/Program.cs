using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of your firm: ");
            string Name = Console.ReadLine();
            Console.Write("Enter your firm address: ");
            string Address = Console.ReadLine();
            Console.Write("Enter a telephone number: ");
            string Telephone = Console.ReadLine();
            Console.Write("Enter a fax number: ");
            string Fax = Console.ReadLine();
            Console.Write("Enter a web site: ");
            string Web = Console.ReadLine();
            Console.Write("Enter the manager's firstname: ");
            string Manager_Firstname = Console.ReadLine();
            Console.Write("Enter the manager's lastname: ");
            string Manager_Lastname = Console.ReadLine();
            Console.Write("Enter the manager's address: ");
            string Manager_Address = Console.ReadLine();
            Console.WriteLine("{0}, {1}, tel:{2} fax:{3}", Name, Address, Telephone, Fax, Web);
            Console.WriteLine("{0} {1}, tel:{2}", Manager_Firstname, Manager_Lastname, Manager_Address);
        }
    }
}
