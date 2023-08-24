using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DATA.Context;
using TMS.DATA.Repository.Interface;
using TMS.DATA.Repository.Repository;

namespace TMS.DATA.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
     

        public TMS_Context _dbContext { get; }

        public IUserRepository _userRepository { get; }

        //public DbContext _dbContext => throw new NotImplementedException();
        public UnitOfWork(TMS_Context context
            ,IUserRepository userRepository)
        {
            _dbContext = context;
            _userRepository = userRepository;
        }
    }
}
