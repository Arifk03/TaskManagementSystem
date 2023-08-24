using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.MODEL;
using TMS.ModelDTO;
using TMS.SERVICE.Interface;
using TMS.UTILITY;

namespace TMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseApiController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ServiceResult<bool>> AddUser(UserModel user)
        {
            return Response(await _userService.AddUser(user));
        }
    }
}
