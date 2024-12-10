using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsubstituteExamples
{
    public class ChildClass(IParent parent ) : IChild
    {
        public void MethodWithNoParams()
        {
            parent.MethodWithNoParams();
        }

        public List<string> MethodWithParamsAndReturnValue(string a, int b)
        {
            return parent.MethodWithParamsAndReturnValue(a, b);
        }
    }
}
