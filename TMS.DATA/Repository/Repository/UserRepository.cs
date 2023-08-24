using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DATA.Context;
using TMS.DATA.Infrastructure;
using TMS.DATA.Repository.Interface;
using TMS.MODEL;

namespace TMS.DATA.Repository.Repository
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        public UserRepository(TMS_Context _dbContext): base(_dbContext)
        {

        }
    }
}
