using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowVsThrowEx
{
    public class Class1
    {
        public void Demo()
        {
            try
            {
                ThrowException1NoEx();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception 1 NO Ex:");
                Debug.WriteLine(ex);
            }

            try
            {
                ThrowException2Ex();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception 2 Ex:");
                Debug.WriteLine(ex);
            }
        }

        private void ThrowException1NoEx()
        {
            try
            {
                DivByZero();
            }
            catch
            {
                throw;
            }
        }
        private void ThrowException2Ex()
        {
            try
            {
                DivByZero();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DivByZero()
        {
            int x = 0;
            int y = 1 / x;
        }
    }
}
