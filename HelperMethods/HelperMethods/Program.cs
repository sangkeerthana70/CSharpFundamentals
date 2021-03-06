﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            

            //calls the DisPlayResult method overload of the first version and takes in three parameters.
            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.WriteLine();

            /*
            //calls the DisPlayResult method overload of the second version and takes only one parameter.
            DisplayResult(ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city) + " " +
                ReverseString(city));
                
            Console.ReadLine();
            */

        }
       
        //rewrite the above method to return a string value and separate out the functionalities it was doing before
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        //move the string formatting in the main method into a separate method
        private static void DisplayResult(string reverseOfFirstName, string reverseOfLastName, string reverseOfCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reverseOfFirstName,
                reverseOfLastName,
                reverseOfCity));
            Console.Read();
        }
        //method overload creates additional version of the same method with the same name but should take in a different signature(Method signature which is the number of arguments and the data types that a method accepts) 
        private static void DisplayResult(string message)//this overload takes in a single parameter and different in signature from the same version method above
        {
            Console.Write("Results: ");
            Console.Write(message);
            
        }


    }
}

