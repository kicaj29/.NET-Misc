using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibB;

namespace LibA
{
    public class Class1LibA
    {
        public Class1LibA()
        {
            
        }

        public string GetName()
        {
            var x = new Class1LibB();
            return "I am lib A; " + x.GetName();
        }
    }
}
