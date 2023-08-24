using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DATA.Context;
using TMS.DATA.Repository.Interface;

namespace TMS.DATA.Infrastructure
{
    public interface IUnitOfWork
    {
        TMS_Context _dbContext { get; }
        IUserRepository _userRepository { get; }    
        
    }
}
