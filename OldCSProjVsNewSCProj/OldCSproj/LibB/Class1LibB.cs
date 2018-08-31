using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibC;

namespace LibB
{
    public class Class1LibB
    {
        public string GetName()
        {
            var x = new Class1LibC();
            return "I am lib B; " + x.GetName();
        }
    }
}
