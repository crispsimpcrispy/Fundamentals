using System;

namespace Chapter05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            aSimpleMethod();
            MethodWithParameters(12,3);
        }
    
        //This method has no parameters
        static void aSimpleMethod()
        {
            Console.WriteLine("You called me");
        }

        //This method needs two parameters called a and b
        static void MethodWithParameters(int a, int b)
        {
            Console.WriteLine("a * b = {0}", a*b);
        }

    }
}