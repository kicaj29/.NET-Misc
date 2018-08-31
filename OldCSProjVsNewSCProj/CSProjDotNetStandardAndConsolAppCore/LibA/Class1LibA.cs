using System;
using LibB;

namespace LibA
{
    public class Class1LibA
    {
        public string GetName()
        {
            var x = new Class1LibB();
            return "I am lib A; " + x.GetName();
        }
    }
}
