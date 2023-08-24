using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.MODEL;
using TMS.ModelDTO;

namespace TMS.SERVICE.Interface
{
    public  interface IUserService
    {
        Task<bool> AddUser(UserModel users);
    }
}
