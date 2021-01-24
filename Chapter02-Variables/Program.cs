using System;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 567;
            //This is implicit casting
            //the int has been converted to a double
            double doubleInteger = aNumber;
            Console.WriteLine("{0} and {1}", aNumber ,doubleInteger);
            
            
            //This is explicit casting
            double aDouble = 156.86;
            int aInteger = (int) aDouble;
            Console.WriteLine("{0} and {1}", aDouble, aInteger);
            
            //Built in conversion
            int varInt = 106;
            double varDouble = 98.5;
            Console.WriteLine(Convert.ToDouble(varInt));
            Console.WriteLine(Convert.ToInt32(varDouble));

        }
    }
}