using TMS.DATA.Infrastructure;
using TMS.DATA.Repository.Interface;
using TMS.DATA.Repository.Repository;

namespace TMS.API.InfraStructure.Installer
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallService(IConfiguration configuration, IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            servicesCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
