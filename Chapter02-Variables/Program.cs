using System;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set variables types
            string myName;
            char myInitial;
            
            //initialise variables
            myName = "Structure Vault";
            myInitial = 'S';

            //write to the console window
            Console.WriteLine("my name is: {0} and my initial is: {1}", myName, myInitial);
        }
    }
}