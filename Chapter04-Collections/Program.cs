using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Chapter04_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int tempOnMon;
            int tempOnTues;
            int tempOnWed;
            int tempOnThur;
            int tempOnFri;
            int tempOnSat;
            int tempOnSun;*/

            int[] arrayOfNumbers = new[] {1, 4, 5, 6};
            Console.WriteLine(arrayOfNumbers[2]);

            //Create a single-dimensional array
            int[] tempArray = new int[7];

            tempArray[0] = 25;
            tempArray[1] = 17;
            tempArray[2] = 18;
            tempArray[3] = 19;
            tempArray[4] = 25;
            tempArray[5] = 22;
            tempArray[6] = 15;

            Console.WriteLine("The temperature on Monday {0}", tempArray[0]);

            //Create a multi-dimensional array
            int[,] tempAndTimeArray = new int[7, 2];

            tempAndTimeArray[0, 0] = 25;
            tempAndTimeArray[1, 0] = 17;
            tempAndTimeArray[2, 0] = 18;
            tempAndTimeArray[3, 0] = 19;
            tempAndTimeArray[4, 0] = 25;
            tempAndTimeArray[5, 0] = 22;
            tempAndTimeArray[6, 0] = 15;

            tempAndTimeArray[0, 1] = 12;
            tempAndTimeArray[1, 1] = 13;
            tempAndTimeArray[2, 1] = 11;
            tempAndTimeArray[3, 1] = 10;
            tempAndTimeArray[4, 1] = 16;
            tempAndTimeArray[5, 1] = 15;
            tempAndTimeArray[6, 1] = 11;

            Console.WriteLine("The temperature on Monday {0} recorded at {1}hr ", tempAndTimeArray[0,0], tempAndTimeArray[0,1]);
            
            
            //Print out the single-dimensional array
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.WriteLine("The temperature recorded was {0}", tempArray[i]);
            }
            
            //Print out the single-dimensional array
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("The temperature recorded was {0}", tempArray[i]);
            }
            
            //Print out the multi-dimensional array
            for (int i = 0; i < tempAndTimeArray.GetLength(0); i++)
            {
                Console.WriteLine("The temperature is {0} recorded at {1}", tempAndTimeArray[i,0], tempAndTimeArray[i,1]);
            }
            
            //Print individual elements of multidimensional array
            for (int i = 0; i < tempAndTimeArray.GetLength(0); i++)
            {
                for (int j = 0; j < tempAndTimeArray.GetLength(1); j++)
                {
                    Console.WriteLine("tempAndTimeArray[{0},{1}] = {2}",i,j,tempAndTimeArray[i,j]);
                }
            }

         
        }
    }
}