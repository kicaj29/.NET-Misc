using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAndDispose
{
    public class CustomerService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose called!");
        }

        public int GetCusomterId()
        {
            return 123;
        }
    }
}
