using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line";// \n adds a new line
            //string myString = "Go to your C:\\ drive";//escape a back slash itself which is a special character
            //string myString = @"Go to your C:\ drive";//@ used in place of \\ to escape the single \

            /*
            //string formatting
            string myString = string.Format("{0} = {1}", "First", "Second");
            Console.WriteLine(myString);
            Console.Read();
            
            //reuse the place holder for replacement code
            string myString1 = string.Format("{1} = {0}", "First", "Second");
            Console.WriteLine(myString1);
            Console.ReadLine();
            Console.WriteLine();
            //using format strings to format currency
            string myString2 = string.Format("{0:c}", 123.45);
            Console.WriteLine(myString2);
            Console.ReadLine();

            //sets place value for a given set of numbers
            string myString3 = string.Format("{0:N}", 12334567890);
            Console.WriteLine(myString3);
            Console.ReadLine();
            */

            /*
            //represent a value as a percent
            string myString4 = string.Format("Percentage: {0:P}", .123);
            Console.WriteLine(myString4);
            Console.ReadLine();

            //creating custom format to format phone numbers in the U.S
            string myString5 = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            Console.WriteLine(myString5);
            Console.ReadLine();
            Console.Read();

            string myStringA = "  That summer we took threes across the board ";
            string myString6 = myStringA.Substring(6, 14);
            Console.WriteLine(myString6);
            Console.ReadLine();
            Console.Read();

            string myString7 = myStringA.ToUpper();
            Console.WriteLine(myString7);
            Console.ReadLine();
            Console.Read();

            string myString8 = myStringA.Replace(" ", "--");
            Console.WriteLine(myString8);
            Console.ReadLine();
            Console.Read();

            string myString9 = myStringA.Remove(6, 14);
            Console.WriteLine(myString9);
            Console.ReadLine();
            Console.Read();

            myStringA = String.Format("Length before: {0} -- Length after {1}", myStringA.Length, myStringA.Trim().Length);
            Console.WriteLine(myStringA);
            Console.ReadLine();
            Console.Read();
            */

            /*
            string newString = "";
            for (int i = 0; i < 100; i++)
            {
                newString += "--" + i.ToString();


            }
            Console.WriteLine(newString);
            Console.ReadLine();
            Console.Read();
            */

            //building string using the StringBuilder class that is an inbuilt class of String
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
            Console.Read();


        }
    }
}
