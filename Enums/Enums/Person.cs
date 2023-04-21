using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Person
    {
        [EnumDataType(typeof(MyEnum))]
        public MyEnum Status { get; set; }
    }
}
