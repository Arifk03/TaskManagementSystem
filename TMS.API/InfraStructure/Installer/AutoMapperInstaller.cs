namespace TMS.API.InfraStructure.Installer
{
    public class AutoMapperInstaller : IInstaller
    {
        public void InstallService(IConfiguration configuration, IServiceCollection service)
        {
            service.AddAutoMapper(typeof(Program));
        }
    }
}
