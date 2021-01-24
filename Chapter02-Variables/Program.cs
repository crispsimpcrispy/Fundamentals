using System;
using System.Runtime.InteropServices;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Booleans
            bool thisVariableIsTrue = true;
            bool thisVariableIsFalse = false;
            Console.WriteLine(thisVariableIsTrue);
            Console.WriteLine(thisVariableIsFalse);

            int a = 10;
            int b = 20;
            int c; //holds the result

            //Addition
            c = a + b;
            Console.WriteLine("Addition: {0}", c);

            //Subtraction
            c = a - b;
            Console.WriteLine("Subtraction: {0}", c);

            //Multiplication
            c = a * b;
            Console.WriteLine("Multiplication {0}", c);

            //Division
            c = b / a;
            Console.WriteLine("Division: {0}", c);

            //Remainder
            c = a % b;
            Console.WriteLine("Remainder: {0}", c);

            //Double multiplication
            Console.WriteLine(15.67 * 558.434);

            //Floating-point division
            float d = 25.5f;
            float e = 18.7f;
            Console.WriteLine(d / e);

            //Increment operator
            int j = 5;
            Console.WriteLine("j = {0}", j); //Output: 5
            Console.WriteLine("j++ = {0}", j++); //Output: 5
            Console.WriteLine("j = {0}", j); //Output: 6
            Console.WriteLine("++j = {0}", ++j); //Output: 7

            //Decrement operator
            int k = 9;
            Console.WriteLine("k = {0}", k); //Output: 9
            Console.WriteLine("--k = {0}", --k); //Output: 8
            Console.WriteLine("k = {0}", k); //Output: 8
            Console.WriteLine("k-- = {0}", k--); //Output: 8

            //Plus and minus operator
            Console.WriteLine(+4); //Output: 4
            Console.WriteLine(-4); //Output: -4

            //Less than operator <
            Console.WriteLine(8 < 5); //Output: false
            Console.WriteLine(4 < 5); //Output: true

            //Greater than operator <
            Console.WriteLine(8 > 5); //Output: true
            Console.WriteLine(4 > 5); //Output: false

            //Greater than or less or equal to
            Console.WriteLine(8 <= 5); //Output: false
            Console.WriteLine(4 >= 4); //Output: true

            //Equality and inequality types
            int var1 = 2;
            int var2 = 3;
            Console.WriteLine(var1 == var2); //Output: false
            Console.WriteLine(var1 != var2); //Output: true

            //Logical negation operator ! and AND
            bool ChangeToFalse = true;
            Console.WriteLine(!ChangeToFalse);
            
            //Logical AND operator &
            bool aFalseValue = false;
            Console.WriteLine(aFalseValue & ChangeToFalse);
            
            //Logical exclusive OR operator ^
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(false ^ false);
            
            //Logical OR operator |
            Console.WriteLine(aFalseValue | ChangeToFalse);
            
            //Conditional logical AND operator &&
            bool TrueOne = false;
            bool TrueTwo = true;
            Console.WriteLine(TrueOne && TrueTwo);
            
            //Conditional logical OR operator ||
            Console.WriteLine(TrueOne || TrueTwo);
            
            //Assignment operator
            int g = 5;
            g += 6;
            Console.WriteLine(g);
            g -= 4;
            Console.WriteLine(g);
            g *= 25;
            Console.WriteLine(g);
            g /= 6;
            Console.WriteLine(g);
            g /= 6;
            Console.WriteLine(g);
            g &= 6;
            Console.WriteLine(g);
            g |= 6;
            Console.WriteLine(g);
            g ^= 6;
            Console.WriteLine(g);
            g >>= 6;
            Console.WriteLine(g);
            g <<= 6;
            Console.WriteLine(g);
            
            //User input
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

            int age;
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} old", age);
        }
    }
}