using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Plainion.Logging;
using Plainion.Prism.Interactivity;
using Plainion.Prism.Regions;
using Plainion.RI;
using Plainion.RI.Logging;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;
using Prism.Navigation.Regions.Behaviors;
using Prism.Unity;

namespace PlainionRI
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(new ModuleInfo(typeof(CoreModule).Name, typeof(CoreModule).AssemblyQualifiedName));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton(typeof(StackPanelRegionAdapter), typeof(StackPanelRegionAdapter));
            containerRegistry.RegisterSingleton(typeof(PopupWindowActionRegionAdapter), typeof(PopupWindowActionRegionAdapter));
            containerRegistry.Register(typeof(DelayedRegionCreationBehavior), typeof(KeepAliveDelayedRegionCreationBehavior));
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(PopupWindowAction), Container.Resolve<PopupWindowActionRegionAdapter>());
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            foreach (var sink in Container.Resolve<IEnumerable<ILoggingSink>>())
            {
                LoggerFactory.AddSink(sink);
            }
            LoggerFactory.GetLogger(GetType()).Notice("Application ready");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DispatcherUnhandledException += OnUnhandledException;

            LoggerFactory.Implementation = new CustomLoggerFactory();
            LoggerFactory.LogLevel = LogLevel.Notice;

            base.OnStartup(e);
        }

        private void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), "Unhandled exception", MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
        }
    }
}
