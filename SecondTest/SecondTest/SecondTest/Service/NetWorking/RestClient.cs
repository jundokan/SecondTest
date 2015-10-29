using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace SecondTest.Service.NetWorking
{
    interface RestClient : IRestClient
    {
        public async Task<string> GetAsync(string uri)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(uri);
            var responce = await httpClient.GetAsync(string.Format("{0}", uri));
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();
            return content;
        }
    }
}
