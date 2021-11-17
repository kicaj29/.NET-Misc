using System;

namespace LambdaClosure
{
    class Program
    {
        static void Main(string[] args)
        {
            var withClosure = new WithClosure();
            var noClosure = new NoClosure();

            var x = withClosure.Substring("ABC");
            var y = noClosure.Substring("XYZ");

            Console.ReadKey();
        }
    }
}
