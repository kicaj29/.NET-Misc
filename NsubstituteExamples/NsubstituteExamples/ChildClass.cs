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

        public List<string> TwoParamsAndReturnList(string a, int b)
        {
            return parent.TwoParamsAndReturnList(a, b);
        }

        public async Task<List<string>> MethodWithParamsAndReturnValueAsync(string a, int b)
        {
            return await parent.MethodWithParamsAndReturnValueAsync(a, b);
        }

        public async Task<string> HandlePersonAsync(Person person)
        {
            return await parent.HandlePersonAsync(person);
        }
    }
}
