using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    public interface ICovariant<out T>
    {
        void DoSomething();
    }
}
