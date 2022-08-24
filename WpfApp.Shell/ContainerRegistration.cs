using Prism.Ioc;
using WpfApp.Shell.ViewModels;

namespace WpfApp.Shell
{
    internal static class ContainerRegistration
    {
        public static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<MainWindowVM>();
        }
    }
}
