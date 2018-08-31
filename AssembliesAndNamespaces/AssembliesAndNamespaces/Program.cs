using System;
using System.IO;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C: \Users\anuradha\Desktop\Selenium\C#Lesson17MicrosoftVirtualAcademy\WriteLinestoText.txt", lines);


            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"C: \Users\anuradha\Desktop\Selenium\C#Lesson17MicrosoftVirtualAcademy\WriteText.txt", text);



           Console.WriteLine("Hello World");
           Console.WriteLine("Using System and System.IO classes from the same namespaces");
           Console.ReadLine();

        }
    }
}
