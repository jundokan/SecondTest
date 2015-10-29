using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondTest.Model;
using SecondTest.Service.NetWorking;

namespace SecondTest.Service.RendomUserService
{
    class RandomUserGetter : IRandomUserGetter
    {
        readonly IRestClient _restClient = new RestClient();
        const string GetUser = "https://randomuser.me/api/";

        public Task<User> GetRendomUser()
        {
            throw new NotImplementedException();
        }
    }
}
