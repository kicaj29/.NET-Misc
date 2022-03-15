using NUnit.Framework;
using System;

namespace TternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sX = null;
            string sY = string.Empty;

            // ?? distinguish null and string.empty, they are not treated as the same value like in string.IsNullOrEmpty
            string s1 = sX ?? "x was null";
            string s2 = sY ?? "y was null";

            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1


            int x = false ? 5 : 55;


            Customer c = null;

            // this will not compile because you cannot assing int? to int
            // int age = c?.Age;

            Assert.AreEqual(66, c?.Age);

            if (c?.IsActive == false)
            {
                Console.WriteLine("Customer is not active");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
