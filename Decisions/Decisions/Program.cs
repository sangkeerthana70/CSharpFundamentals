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
            /*
            Console.WriteLine("Anu's big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3");
            string userValue = Console.ReadLine();

            string message;

            if (userValue == "1")               
                message = "You won a car!";           
            else if (userValue == "2")           
                message = "You won a boat!";           
            else if (userValue == "3")          
                message = "You won a bike!";
            else
            {
                message = "Sorry, we did not understand.";
                //message = message + "You lose.";
                message += "You lose.";

            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            /*
            //ternary operators used only if there is one if and else condition.
            //condition ? first_expression : second_expression; 
            Console.WriteLine("Anu's big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "a bicycle";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.ReadLine();

            //string formatting
            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered number: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();
            */

            /*
            string result = SpeedingIfElse.IssueSpeedTicket(100);
            Console.WriteLine(result);
            Console.ReadLine();
            */

            //TDD Phase
            int speed;
            string ticket;

            speed = 0;
            ticket  = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ",  speed, ticket);

            speed = 50;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 60;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 61;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 79;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 80;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);


            speed = 81;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = -49;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);





        }
    }
}
