using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWIthLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            //The following example demonstrates the default constructor of the List<T> generic class.
            //The default constructor creates a list with the default capacity, 
            //as demonstrated by displaying the Capacity property.

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            Console.WriteLine();

            foreach(string dinosuar in dinosaurs)
            {
                Console.WriteLine(dinosuar);
            }

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);
        }
    }
}
