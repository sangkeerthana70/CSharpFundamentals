using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anu's big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3");
            string userValue = Console.ReadLine();

            string message;

            if (userValue == "1")
            {
                message = "You won a car!";
                //Console.WriteLine(message);

            }
            else if (userValue == "2")
            {
                message = "You won a boat!";
                //Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                message = "You won a bike!";
                //Console.WriteLine(message);
            }
            else
            {
                message = "Sorry, we did not understand.";
                
            }
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
