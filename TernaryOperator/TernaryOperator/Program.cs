using NUnit.Framework;
using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string zz = "abc";
            Customer c = null;
            zz = c?.Name;
            Console.WriteLine(zz); // will print: "" because zz will be set on null

            zz = null;
            zz ??= "zz is set";
            Console.WriteLine(zz); // will print: "zz is set"

            string sX = null;
            string sY = string.Empty;


            // ?? distinguish null and string.empty, they are not treated as the same value like in string.IsNullOrEmpty
            string s1 = sX ?? "x was null";
            string s2 = sY ?? "y was null";

            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1


            int x = false ? 5 : 55;


            c = null;

            // this will not compile because you cannot assing int? to int
            // int age = c?.Age;

            // Assert.AreEqual(66, c?.Age);    // NUnit.Framework.AssertionException: '  Expected: 66 But was:  null '

            if (c?.IsActive == false)
            {
                Console.WriteLine("Customer is not active");
            }

            // c = new Customer();
            // _ = c?.Name ?? throw new ArgumentNullException("x");  // System.ArgumentNullException: 'Value cannot be null. (Parameter 'x')'
            c = null;
            _ = c?.Name ?? throw new ArgumentNullException("x");  // System.ArgumentNullException: 'Value cannot be null. (Parameter 'x')'






            Console.WriteLine("Hello World!");
        }
    }
}
