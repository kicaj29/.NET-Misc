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
    }
}
