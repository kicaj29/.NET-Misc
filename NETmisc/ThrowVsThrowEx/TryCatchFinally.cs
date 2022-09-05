using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowVsThrowEx
{
    public class TryCatchFinally
    {
        public void Test()
        {

            try
            {
                throw new MyException();
            }
            catch (Exception ex)
            {

            }

            try
            {
                try
                {
                    throw new Exception("Excpetion1");
                }
                finally
                {
                    Console.WriteLine("finally1");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
