using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //to add days or hours
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(5).ToLongTimeString());

            //to subtract days or hours use negative values
            //Console.WriteLine(myValue.AddDays(-2).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-7).ToLongTimeString());

            //get snapshot of a date or time
            Console.WriteLine("This is the month " + " " + myValue.Month + " of the year");

            //DateTime myBirthday = new DateTime(1945, 8, 15);
            //Console.WriteLine(myBirthday.ToLongDateString());
            //Console.WriteLine(myBirthday.ToShortDateString());
            //Console.WriteLine(myBirthday);

            //calculate timespan for a period of time
            DateTime myBirthday = DateTime.Parse("8/15/1945");//converts string to date
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("My age in days alive :" + myAge.TotalDays + " days");
            Console.Read();
        }
    }
}
