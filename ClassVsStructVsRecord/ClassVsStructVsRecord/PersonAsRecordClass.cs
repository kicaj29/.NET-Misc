using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructVsRecord
{
    // by default record is a class, so adding class name does not change anything
    // with such definition record props are immutable!
    internal record class PersonAsRecordClass (string FullName, DateOnly DateOfBirth)
    {
        protected PersonAsRecordClass(PersonAsRecordClass source)
        {
            FullName = source.FullName;
            DateOfBirth = source.DateOfBirth;
        }
    }

    // we cannot define a class in this short form, the code below does not compile
    // internal class PersonAsClassShort(string FullName, DateOnly DateOfBirth);

    /// <summary>
    /// This is the same as PersonAsRecordClass but requires more lines of code.
    /// </summary>
    internal record class PersonAsRecordClassLongerVersion
    {
        internal PersonAsRecordClassLongerVersion(string fullName, DateOnly dateOfBirth)
        {
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
        }

        internal string FullName { get; init; }
        internal DateOnly DateOfBirth { get; init; }
    }
}
