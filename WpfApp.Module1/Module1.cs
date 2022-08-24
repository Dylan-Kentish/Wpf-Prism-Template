using Prism.Ioc;
using Prism.Modularity;
using Serilog;

namespace WpfApp.Module1
{
    public class Module1 : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<ILogger>().Information("Module 1 Initialized");
        }
    }
}