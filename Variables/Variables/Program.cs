
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //understanding Data Types and Variables

            /*
            int x;
            int y;

            x = 200;
            y = x + 800;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;            
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            //simplify the above lines of code
            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();
            

            Console.WriteLine("Hello!! " + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
