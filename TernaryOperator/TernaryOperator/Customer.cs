using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    public class Customer
    {
        public bool IsActive { get; init; } = true;
        public int Age { get; init; } = 67;

        public string? Name { get; set; }

        public string SomeMethod()
        {
            return "aaaa";
        }

    }
}
