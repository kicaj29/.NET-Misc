using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string GetFullName(this Customer customer)
        {
            if (customer == null)
            {
                return null;
            }
            else
            {
                return customer.Name + customer.SecondName;
            }
        }
    }
}
