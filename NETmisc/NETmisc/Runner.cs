using dynamicVSvarVSobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowVsThrowEx;

namespace NETmisc
{
    internal static class Runner
    {
        public static void RunThrowVsThrowEx()
        {
            try
            {
                Class1 obj = new Class1();
                obj.Demo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace?.ToString());
            }
        }

        public static void RunCovarianceAndContravariance()
        {
            CovarianceAndContravariance.RunMe.Run();
        }

        public static void RunDoubleQuestionMark()
        {
            string x = null!;
            string y = string.Empty;
            string z = default(string)!;

            string x1 = x ?? "abc";
            string y1 = y ?? "abc";
            string z1 = z ?? "abc";
        }

        public static void RunDynamicVsObject()
        {
            // DynamicVarObject.Go();
            DynamicVarObject.ObjectVsDynamic();
            DynamicVarObject.ConvertFromStringJsonToDynamic();
        }
    }
}
