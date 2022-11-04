using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructVsRecord
{
    // by default record is a class so we have to specify struct to use it as a struct
    // with such definition record props are immutable!
    internal record struct PersonAsRecordStruct(string FullName, DateOnly DateOfBirth);
}
