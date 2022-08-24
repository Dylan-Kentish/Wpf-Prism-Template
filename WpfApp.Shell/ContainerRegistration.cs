using Prism.Ioc;
using Serilog;

namespace WpfApp.Shell
{
    internal static class ContainerRegistration
    {
        public static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILogger>(() => Log.Logger);
        }
    }
}
