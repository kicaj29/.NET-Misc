﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibA;

namespace OldCSproj
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
