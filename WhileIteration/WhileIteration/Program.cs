using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
           
        }


        public static bool MainMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if(result == "2")
            {
                GuessingGame();
                return true;
            }
            else if(result == "3")
            {
                return false;//exit method
            }
            else
            {
                return true;//any other option entered will prompt the while loop again
            }

        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers");
            Console.ReadLine();

        }

        private static void GuessingGame()
        { 
            Console.WriteLine("Guesssing game");
            Console.ReadLine();
        }
    }
}
