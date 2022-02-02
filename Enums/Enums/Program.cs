using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // try parse executes trim operation before parsing!
            if (Enum.TryParse("  ExpORted  ", ignoreCase: true, out MyEnum result))
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
