using System;

namespace Chaper03_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3;

            //If statement
            if (value == 3)
            {
                Console.WriteLine("Value = 3");
            }
            
            //If else statement
            if (value < 1)
            {
                Console.WriteLine("value is less than 1");
            }
            else
            {
                Console.WriteLine("value is greater than 1");
            }
            
            //Else if statement
            if (value == 1)
            {
                Console.WriteLine("value is equal to 1");
            }
            else if (value == 2)
            {
                Console.WriteLine("value is equal to 2");
            }
            else if (value == 3)
            {
                Console.WriteLine("value is equal to 3");
            }
            else
            {
                Console.WriteLine("value not equal to anything");
            }
            
            //switch statements
            int b = 2;
            
            switch (b)
            {
                case 1:
                    Console.WriteLine("B is equal to 1");
                    break;
                case 2:
                    Console.WriteLine("B is equal to 2");
                    break;
                case 3:
                    Console.WriteLine("B is equal to 3");
                    break;
                default:
                    Console.WriteLine("B is not eqaul to anything");
                    break;
            }
            
            //Do Loop
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 4);
            
            //While loop
            int n = 1;
            while (n <= 5)
            {
                Console.WriteLine(n);
                n++;
            }
            
            //For loop
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            
            //Foreach loop
            int[] anArrayOfInts = {1, 3, 4, 6, 77};
            foreach (var singleInt in anArrayOfInts)
            {
                Console.WriteLine(singleInt);
            }
            
            //Break statement
            n = 0;
            while (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                if (n == 3)
                {
                    break;
                }
            }
            
            //Continue statement
            for (i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
            //Goto statement
            int y = 10;
            if (y == 10)
            {
                goto LINE8000;
            }

            Console.WriteLine("This wont be displayed");
            
            LINE8000:
            Console.WriteLine("This is line8000");
            
        }
    }
}