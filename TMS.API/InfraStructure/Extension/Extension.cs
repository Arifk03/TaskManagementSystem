using TMS.API.InfraStructure.Installer;

namespace TMS.API.InfraStructure.Extension
{
    public static class Extention
    {
        public static void InstallAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installer = typeof(Program).Assembly.ExportedTypes.Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();
            installer.ForEach(installer => installer.InstallService(configuration, services));
        }
    }
}
