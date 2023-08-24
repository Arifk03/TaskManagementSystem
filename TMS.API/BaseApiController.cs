using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.UTILITY;

namespace TMS.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected int UserId => int.TryParse(User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value, out int value) ? value : 1;

        [NonAction]
        public new ServiceResult<T> Response<T>(T data)
        {
            var serviceResult = new ServiceResult<T>();
            if (data != null)
            {
                serviceResult.SetSucces(data);
            }
            return serviceResult;
        }
    }
}
