using System;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 14.56;
            Console.WriteLine("price: {0}", price);
            Console.WriteLine("sizeof: {0}", sizeof(double));
            Console.WriteLine("default: {0}", default(double));
            Console.WriteLine("min value: {0}", double.MinValue);
            Console.WriteLine("max value: {0}", double.MaxValue);
            Console.WriteLine("type: {0}", price.GetType());
            Console.WriteLine("code: {0}", price.GetTypeCode());
            Console.WriteLine("price: £{0}", price.ToString());

            string myName = "Structure Vault";
            Console.WriteLine("my name: {0}", myName);
            Console.WriteLine("type: {0}", myName.GetType());
            Console.WriteLine("code: {0}", myName.GetTypeCode());
        }
    }
}