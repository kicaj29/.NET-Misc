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
    public class RequeueVisibilityTimeoutOption<TException> where TException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequeueVisibilityTimeoutOption{TException}"/> class.
        /// </summary>
        public RequeueVisibilityTimeoutOption()
        {
        }

        internal bool IsForException(Exception ex)
        {
            return typeof(TException) == ex.GetType();
        }
    }
}
