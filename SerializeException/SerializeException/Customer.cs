using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeException
{
    public class Customer
    {
        public Customer() : base()
        {

        }
        public Customer(string firstName, string secondName) : base()
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
    }
}
