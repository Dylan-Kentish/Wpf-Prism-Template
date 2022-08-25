using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Serilog;
using WpfApp.Infrastructure;
using WpfApp.Module1.ViewModels;
using WpfApp.Module1.Views;

namespace WpfApp.Module1
{
    public class Module1 : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView, MainViewVM>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<ILogger>().Information("Module 1 Initialized");

            var regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RequestNavigate(RegionNames.Root, nameof(MainView));
        }
    }
}