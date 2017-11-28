using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    public static class RunMe
    {
        public static void Run()
        {
            var cc = new TheInsAndOuts();
            cc.Covariance();
            cc.Contravariance();
        }
    }
}
