using TMS.SERVICE.Interface;
using TMS.SERVICE.Repository;

namespace TMS.API.InfraStructure.Installer
{
    public class RepoInstaller : IInstaller
    {
        public void InstallService(IConfiguration configuration, IServiceCollection service)
        {
            service.AddTransient(typeof(IUserService), typeof(UserService));
        }
    }
}
