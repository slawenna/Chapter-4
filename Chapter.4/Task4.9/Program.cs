using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;



            Console.Write("Enter numbers count: ");

            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)

            {

                Console.Write("Enter number {0}: ", i + 1);

                sum += int.Parse(Console.ReadLine());

            }



            Console.WriteLine("Sum of all numbers is: " + sum);
        }
    }
}
