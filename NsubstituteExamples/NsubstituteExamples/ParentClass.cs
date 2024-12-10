using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsubstituteExamples
{
    public class ParentClass : IParent
    {
        public void MethodWithNoParams()
        {
           Console.WriteLine("ParentClass.DoSomething() called");
        }

        public List<string> TwoParamsAndReturnList(string a, int b)
        {
            Console.WriteLine("ParentClass.TwoParamsAndReturnList() called");

            return ["abc", "xyz"];
        }

        public async Task<List<string>> MethodWithParamsAndReturnValueAsync(string a, int b)
        {
            Console.WriteLine("ParentClass.MethodWithParamsAndReturnValueAsync() called");

            return await Task.FromResult(new List<string>(new string[] { "abc", "xyz" }));
        }

        public async Task<string> HandlePersonAsync(Person person)
        {
            Console.WriteLine("ParentClass.HandlePersonAsync() called");

            return await Task.FromResult($"{person.Name}_{person.Age}");
        }
    }
}
