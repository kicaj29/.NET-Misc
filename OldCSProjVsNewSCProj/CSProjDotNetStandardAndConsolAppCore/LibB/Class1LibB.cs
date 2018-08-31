using System;
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
