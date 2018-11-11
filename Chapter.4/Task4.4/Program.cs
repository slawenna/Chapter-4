using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int natural = 1234;
            int negative = - 34567;
            int positive = 3447;
            Console.WriteLine("{0,-10:x}{1,-10:f2}{2,-10:f2}", natural, positive, negative);
        }
    }
}
