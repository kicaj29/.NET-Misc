using System;
using LibA;

namespace CSProjDotNetStandardAndConsolAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Class1LibA();

            Console.WriteLine(x.GetName());

            Console.ReadKey();
        }
    }
}
