using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibWithConfig
{
    public class Class1
    {
        public string GetValueFromConfig()
        {
            return System.Configuration.ConfigurationManager.AppSettings["dllConfigParam"];
        }
    }
}
