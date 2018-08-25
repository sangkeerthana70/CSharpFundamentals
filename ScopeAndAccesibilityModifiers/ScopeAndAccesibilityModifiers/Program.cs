using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeAndAccesibilityModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.ReadLine();
        }
    }
}
