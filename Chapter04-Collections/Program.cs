using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace Chapter04_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a list of strings
            List<string> groceries = new List<string>();
            
            //Add some items to the list
            groceries.Add("Milk");
            groceries.Add("One Egg");
            groceries.Add("Flour");
            groceries.Add("Butter");

            foreach (var item in groceries)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}