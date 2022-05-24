using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializeException
{
    public class CustomerException : Exception
    {
        public CustomerException() : base()
        {

        }
        public CustomerException(string firstName, string secondName) : base()
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName { get; private set; }
        public string SecondName { get; private set; }


        /*public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("firstName", FirstName);
        }*/
    }
}
