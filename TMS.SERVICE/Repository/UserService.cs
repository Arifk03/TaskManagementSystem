using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DATA.Context;
using TMS.MODEL;
using TMS.ModelDTO;
using TMS.SERVICE.Interface;

namespace TMS.SERVICE.Repository
{
    public class UserService : IUserService
    {
		private readonly TMS_Context _dbContext;
        public UserService(TMS_Context dbContext)
        {

            _dbContext = dbContext;

        }
        public async Task<bool> AddUser(UserModel users)
        {
			try
			{
				var user = new Users();
				user.Name = users.Name;
				user.Email = users.Email;
				user.Password = users.Password;
				user.Role = users.Role;
				user.CreatedDate = DateTime.Now;
				user.ModifiedDate = DateTime.Now;
				user.IsActive = true;

				await _dbContext.Users.AddAsync(user);
				return true;
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
