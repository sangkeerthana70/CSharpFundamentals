using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the properties
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            //getting the properties
            Console.WriteLine(" {0}, {1}, {2}, {3}",
                myCar.Make, 
                myCar.Model,
                myCar.Year, 
                myCar.Color);
            //Console.Read();

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("The value of myCar is {0:C}", value);
            //Console.ReadLine();
            

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 5000.0M;
            return carValue;

        }
    }

    //Class car is a datatype of Car which is our custom datatype
    class Car
    {
        //properties
        public string  Make { get; set; }
        public string  Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }

    }
}
