using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    /// <summary>
    /// Specifies the options for re-queuing visibility timeout.
    /// </summary>
    /// <typeparam name="TException">The type of exception that this requeue visibility timeout option applies to.</typeparam>
    public interface IRequeueVisibilityTimeoutOption<out TException> where TException : Exception
    {
        bool IsForException(Exception ex);

        Func<Task<int>>? GetVisibilityTimeoutAction { get; set; }
    }
}
