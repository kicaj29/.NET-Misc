using System;

namespace TternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 2;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1


            int x = false ? 5 : 55;

            Console.WriteLine("Hello World!");
        }
    }
}
