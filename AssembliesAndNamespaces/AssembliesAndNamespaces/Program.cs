using System;
using System.IO;
using System.Net;

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
            File.WriteAllLines(@"C:\Users\anuradha\Desktop\Selenium\C#Lesson17\WriteLinestoText.txt", lines);


            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"C:\Users\anuradha\Desktop\Selenium\C#Lesson17\WriteText.txt", text);


            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\anuradha\Desktop\Selenium\C#Lesson17\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\anuradha\Desktop\Selenium\C#Lesson17\WriteLines2.txt", true))
            {
                file.WriteLine("Fourth line");
            }


            Console.WriteLine("Hello World");
            Console.WriteLine("Using System and System.IO classes from the same namespaces");
            Console.ReadLine();

            WebClient Client = new WebClient();
            string reply = Client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\anuradha@\Desktop\Selenium\C#Lesson17\Downloaded.txt", reply);
            Console.ReadLine();


        }
    }
}
