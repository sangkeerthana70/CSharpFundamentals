//using System;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C: \Users\anuradha\Desktop\Selenium\C#Lesson17MicrosoftVirtualAcademy\WriteText.txt", text);



            System.Console.WriteLine("Hello World");
            System.Console.ReadLine();

        }
    }
}
