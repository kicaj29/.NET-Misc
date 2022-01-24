using NUnit.Framework;
using System;

namespace TternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
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
