using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondTest.Model;

namespace SecondTest.Service.RandomUserService
{
    interface IRandomUserGetter
    {
        Task<User> GetRandomUser();
    }
}
