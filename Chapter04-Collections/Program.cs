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
            //Create a dictionary
            IDictionary<int, string> groceries = new Dictionary<int, string>();
            
            groceries.Add(1, "Milk");
            groceries.Add(2, "Cream");
            groceries.Add(3, "One Egg");
            groceries.Add(4, "Flour");
            groceries.Add(5, "Butter");

            foreach (var grocery in groceries)
            {
                Console.WriteLine(grocery);
            }

            foreach (var grocery in groceries)
            {
                Console.WriteLine("Key: {0}, Value: {1}",grocery.Key,grocery.Value);
            }
          
        }
    }
}