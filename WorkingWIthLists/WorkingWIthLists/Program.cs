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


            //The following example demonstrates the default constructor of the List<T> generic class.
            //The default constructor creates a list with the default capacity, 
            //as demonstrated by displaying the Capacity property.
            //The capacity of a List<T> is the number of elements that the List<T> can hold.
            //As elements are added to a List<T>, the capacity is automatically increased as required by 
            //reallocating the internal array.

            List<string> dinosaurs = new List<string>();

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
            //check if the list contains a value that we are looking for and returns a bool
            Console.WriteLine("\nContains(\"Deinonychus\"): {0}", dinosaurs.Contains("Deinonychus"));

            //insert a value
            Console.WriteLine("\nInsert(2, \"Compsognathus\")");
            dinosaurs.Insert(2, "Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            // Shows accessing the list using the Item or index value property.
            Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

            //remove an item from the list
            Console.WriteLine("\nRemove(\"Compsognathus\")");
            dinosaurs.Remove("Compsognathus");

            Console.WriteLine();
            foreach(string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            //TrimExcess Method
            //Sets the capacity to the actual number of elements in the List<T>, 
            //if that number is less than a threshold value.
            dinosaurs.TrimExcess();
            Console.WriteLine("\nTrimExcess()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);//capacity changes as the elements in the list are added or removed
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            //The Clear method is used at the end of the program, to remove all items from the list, 
            //and the Capacity and Count properties are then displayed.
            dinosaurs.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);
        }
    }
}
