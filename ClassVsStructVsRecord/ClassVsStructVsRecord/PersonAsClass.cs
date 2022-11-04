using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructVsRecord
{
    internal class PersonAsClass
    {
        internal PersonAsClass(string fullName, DateOnly dateOfBirth)
        {
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
        }

        internal string FullName { get; set; }
        internal DateOnly DateOfBirth { get; set; }
    }
}
