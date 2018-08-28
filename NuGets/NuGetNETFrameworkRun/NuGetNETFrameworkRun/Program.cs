using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;

namespace NuGetNETFrameworkRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Class2 x = new Class2();
            x.SomeProperty = new Class1();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
