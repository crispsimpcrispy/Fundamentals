using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Chapter04_Collections
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday, 
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days selectedDay = Days.Wednesday;

            switch (selectedDay)
            {
                case Days.Monday:
                    Console.WriteLine("Monday selected");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Tuesday selected");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Wednesday selected");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Thursday selected");
                    break;
                case Days.Friday:
                    Console.WriteLine("Friday selected");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Saturday selected");
                    break;
                case Days.Sunday:
                    Console.WriteLine("Sunday selected");
                    break;
            }
        }
    }
}