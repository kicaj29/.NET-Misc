using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicVSvarVSobject
{
    public class SimpleClass
    {
        object FieldObject = "a";
        // var FieldVar; // will not compile
        dynamic FieldDynamic = "a";

        object? PropertyObject { get; set; }
        // var PropertyVar { get; set; } // will not compile
        dynamic? PropertyDynamic { get; set; }
    }
}
