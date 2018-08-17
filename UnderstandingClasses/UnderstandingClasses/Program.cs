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
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine(" {0}, {1}, {2}, {3}",
                myCar.Make, 
                myCar.Model,
                myCar.Year, 
                myCar.Color);
            Console.Read();
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

    }
}
