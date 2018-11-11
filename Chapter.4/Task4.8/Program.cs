using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");

            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");

            double c = double.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");

            double d = double.Parse(Console.ReadLine());

            Console.Write("Enter a number: "); 

            double e = double.Parse(Console.ReadLine());
           
            if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} is the biggest.", a);

            else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} is the biggest.", b);

            else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} is the biggest.", c);

            else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} is the biggest.", d);

            else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} is the biggest.", e);

            else Console.WriteLine("There isn't a biggest number.");

        }
    }
}
