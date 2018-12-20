using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibC;
using LibD;

namespace LibB
{
    public class Class1LibB
    {
        public string GetName()
        {
            var x = new Class1LibC();
            var y = new Class1LibD();

            return "I am lib B; " + x.GetName() + y.GetName();
        }
    }
}
