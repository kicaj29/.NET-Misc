using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MultiTargeting.Services
{
    public class MyService
    {
        public async void CallSomeEndpointAsync()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("not set", UriKind.Absolute));
            HttpClient client = new HttpClient();
            System.Net.Http.HttpResponseMessage response = await client.SendAsync(request);
        }
    }
}
