using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondTest.Model;

namespace SecondTest.Service.RendomUserService
{
    interface IRandomUserGetter
    {
        Task<User> GetRendomUser();
    }
}
