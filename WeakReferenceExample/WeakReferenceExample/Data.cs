using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakReferenceExample
{
    public class Data
    {
        private byte[] _data;
        private string _name;
        public bool IsFinalized { get; set; }

        public Data(int size)
        {
            _data = new byte[size * 1024];
            _name = size.ToString();
        }

        ~Data()
        {
            Console.WriteLine("finalizer executed");
            IsFinalized = true;
        }

        // Simple property.
        public string Name
        {
            get { return _name; }
        }
    }
}
