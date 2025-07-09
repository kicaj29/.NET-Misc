using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    public static class RunMe
    {
        public static void Run()
        {
            IRequeueVisibilityTimeoutOption<Exception>[] myArray = [
                new RequeueVisibilityTimeoutOption<InvalidOperationException>()
                ];

            bool isForException = myArray[0].IsForException(new InvalidOperationException());

            var cc = new TheInsAndOuts();
            cc.Covariance();
            cc.Contravariance();
        }

        public static void ProcessArray(RequeueVisibilityTimeoutOption<Exception>[] myArray)
        {
            Debug.WriteLine("Processing array of RequeueVisibilityTimeoutOption<Exception>...");
        }
    }
}
