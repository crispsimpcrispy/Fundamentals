using System;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a single line comment

            /* This is a
             multi-line
             comment */

            Console.WriteLine("Hello World!");

            sbyte a = 10;
            byte b = 12;
            short c = -45;
            ushort d = 25406;
            int e = 5689445;
            uint f = 899888998;
            long g = -4554285618754;
            ulong h = 18446744073709551615;
            float j = 1.5f;
            double k = 16.586;
            decimal m = 156.68m;

            Console.WriteLine("sbyte: " + a);
            Console.WriteLine("byte: " + b);
            Console.WriteLine("short: " + c);
            Console.WriteLine("ushort: " + d);
            Console.WriteLine("int: " + e);
            Console.WriteLine("uint: " + f);
            Console.WriteLine("long: " + g);
            Console.WriteLine("ulong: " + h);
            Console.WriteLine("float: " + j);
            Console.WriteLine("double: " + k);
            Console.WriteLine("decimal: " + m);
            
            Console.WriteLine("sbyte: {0}", a);
            
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}