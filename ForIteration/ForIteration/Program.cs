﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
               //Console.WriteLine(i);
               if ( i == 7)
                {
                    Console.WriteLine("Found my lucky number: " + i);
                    break;
                }
            }

            //Example of using a code snippet in a for loop and replacing values in a code snippet
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);

            }
            Console.ReadLine();
        }
    }
}
