using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAndDispose
{
    public class FileWriter : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("FileWriter: Dispose");
        }
    }
}
