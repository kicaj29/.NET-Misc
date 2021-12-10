using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAndDispose
{
    public class ServiceRegistry
    {
        public CustomerService GetCusomterService()
        {
            return new CustomerService();
            // return null;
        }

        public Task<CustomerService> GetCusomterServiceAsync()
        {
            return Task.FromResult(new CustomerService());
        }
    }
}
