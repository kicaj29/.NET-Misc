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
            for(int index =0; index < 1000; index++)
            {
                HashCode.Combine("AAAAAAA" + index.ToString(), "BBBBBBB", "CCCCCCCC", "DDDDDDD", "EEEEEEE", "FFFFFFF");
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
