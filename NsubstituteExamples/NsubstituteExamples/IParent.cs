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

        List<string> TwoParamsAndReturnList(string a, int b);

        Task<List<string>> MethodWithParamsAndReturnValueAsync(string a, int b);

        Task<string> HandlePersonAsync(Person person);
    }
}
