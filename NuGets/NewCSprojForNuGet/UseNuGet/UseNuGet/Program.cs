﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibA;

namespace UseNuGet
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
