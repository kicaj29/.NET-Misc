using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibWithConfig;

namespace ConsoleAppConfigFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new Class1();
            Console.WriteLine(i.GetValueFromConfig());
            Console.ReadKey();
        }
    }
}
