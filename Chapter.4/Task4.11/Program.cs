﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0;

            int f2 = 1;

            int sum = 1;

            int count = 0;

            Console.WriteLine(f1);

            while (count < 100)

            {

                sum = f1 + f2;

                f1 = f2;

                f2 = sum;

                Console.WriteLine(f2);

                count++;
                
            }

        }
    }
}
