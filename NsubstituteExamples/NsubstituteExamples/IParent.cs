using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsubstituteExamples
{
    public interface IParent
    {
        void MethodWithNoParams();

        List<string> MethodWithParamsAndReturnValue(string a, int b);
    }
}
