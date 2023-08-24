using Microsoft.EntityFrameworkCore;
using TMS.API.InfraStructure.Installer;
using TMS.DATA.Context;

namespace TMS.API.InfraStructure.Connection
{
    public class AddDbContextConnection : IInstaller
    {
        public void InstallService(IConfiguration configuration, IServiceCollection service)
        {
            service.AddDbContext<TMS_Context>(x => x.UseSqlServer(configuration["ConnectionStrings:con"]));
        }
    }
}
