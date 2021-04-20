using System;
using System.Globalization;
using System.Threading;

namespace CultureInfoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Culture = {0}", Thread.CurrentThread.CurrentCulture.DisplayName);
            Console.WriteLine("(file == FILE) = {0}", (string.Compare("file", "FILE", true) == 0));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Console.WriteLine("Culture = {0}", Thread.CurrentThread.CurrentCulture.DisplayName);
            Console.WriteLine("(file == FILE) = {0}", (string.Compare("file", "FILE", true) == 0));

            string invariant = "iii".ToUpper(CultureInfo.InvariantCulture);
            string cultured = "iii".ToUpper(new CultureInfo("tr-TR"));

            Console.WriteLine(invariant);
            Console.WriteLine(cultured);

            Console.ReadKey();
        }
    }
}
