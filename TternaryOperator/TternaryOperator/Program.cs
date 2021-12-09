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

            Console.WriteLine("Hello World!");
        }
    }
}
