namespace TMS.API.InfraStructure.Installer
{
    public interface IInstaller
    {
        void InstallService(IConfiguration configuration, IServiceCollection servicesCollection);
    }
}
