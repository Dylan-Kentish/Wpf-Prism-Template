using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Serilog;

namespace WpfApp.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        /* Prism applications startup in the following order:
        *
        * 01 CreateContainerExtension
        * 02 CreateModuleCatalog
        * 03 RegisterRequiredTypes
        * 04 RegisterSingletons
        * 05 ConfigureModuleCatalog
        * 06 ConfigureRegionAdapterMappings
        * 07 ConfigureDefaultRegionBehaviours
        * 08 RegisterFrameworkExceptionTypes
        * 09 CreateShell
        * 10 InitializeShell
        * 11 InitializeModules
        *
        * Initialization sequence is triggered by the OnStartup event.
        * See https://github.com/PrismLibrary/Prism/blob/master/src/Wpf/Prism.Wpf/PrismApplicationBase.cs for more info.
        */

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Logger = new LoggerConfiguration().CreateLogger();

            Log.Information("Starting up");

            base.OnStartup(e);
        }

        protected override IContainerExtension CreateContainerExtension() => new UnityContainerExtension();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ContainerRegistration.RegisterTypes(containerRegistry);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
        
            Log.Logger.Information("Configure Module Catalog");

            // Look into alternatives.
            var module1 = typeof(Module1.Module1);
            moduleCatalog.AddModule(
                new ModuleInfo
                {
                    ModuleName = module1.Name,
                    ModuleType = module1.AssemblyQualifiedName,
                });
        }

        protected override Window CreateShell()
        {
            Log.Logger.Information("Create Shell");
            return Container.Resolve<MainWindow>();
        } 

        protected override void InitializeShell(Window shell)
        {
            Log.Logger.Information("Initialize Shell");
            base.InitializeShell(shell);
        }

        protected override void InitializeModules()
        {
            Log.Logger.Information("Initialize Modules");
            base.InitializeModules();
        }

        protected override void OnInitialized()
        {
            Log.Logger.Information("Initialized");
            base.OnInitialized();
        }
    }
}
