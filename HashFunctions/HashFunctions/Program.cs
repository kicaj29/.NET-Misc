using System;
using System.Diagnostics;

namespace HashFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int index =0; index < 200; index++)
            {
                HashCode.Combine("AAAAAAA", "BBBBBBB", "CCCCCCCC", "DDDDDDD", "EEEEEEE", "FFFFFFF");
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
