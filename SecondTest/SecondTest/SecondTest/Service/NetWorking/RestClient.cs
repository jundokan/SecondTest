using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace SecondTest.Service.NetWorking
{
    class RestClient : IRestClient
    {
        public async Task<string> GetAsync(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(uri);
                var responce = await httpClient.GetAsync($"{uri}");
                responce.EnsureSuccessStatusCode();
                var content = await responce.Content.ReadAsStringAsync();
                return content;
            }
        }
    }
}
