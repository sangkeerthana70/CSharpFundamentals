using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
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

            Car myOtherCar;
            myOtherCar = myCar;//myOtherCar is a variable that refers to the same memory address as myCar.

            Console.WriteLine("Variable myOtherCar points to same memory as myCar: {0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";//changing myCar.Model("Cutlas Supreme" to myOtherCar.Model ("98")
            Console.WriteLine();
            Console.WriteLine("Checking to see myOtherCar and myCar hold " +
                "same variable as they point to same memory:" + " " +
                "{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            //setting myOtherCar object reference to null
            myOtherCar = null;//null is not zero or empty but indeterminate 
            /*
            Console.WriteLine("Variable myOtherCar points to same memory as myCar: {0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            //null reference exception unhandled will be thrown
            */

            //setting myCar object also as null and this removes all references to memory
            myCar = null;
            Console.ReadLine();
        }//this block ends the references to the two objects by releasing them from  memory or in other words the object goes out of scope after this block
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
