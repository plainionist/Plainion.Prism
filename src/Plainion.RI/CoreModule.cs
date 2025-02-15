using Plainion.RI.InteractionRequests;
using Plainion.RI.InteractionRequests.Dialogs;
using Plainion.RI.Logging;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;

namespace Plainion.RI
{
    class CoreModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewAsContentView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewModelAsContentView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(CustomNotificationView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(ComplexCustomViewView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnContentControlView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowActionView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowContentControlView));
            regionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionWithPopupWindowActionExtensionsView));

            regionManager.RegisterViewWithRegion("RegionOnContentControlView", typeof(ComplexDialog));
            regionManager.RegisterViewWithRegion("RegionOnPopupWindowActionView", typeof(ComplexDialog));
            regionManager.RegisterViewWithRegion("RegionOnPopupWindowContentControlView", typeof(ComplexDialog));
            regionManager.RegisterViewWithRegion("RegionWithPopupWindowActionExtensionsView", typeof(ComplexDialog));

            regionManager.RegisterViewWithRegion(RegionNames.StatusBar, typeof(StatusBarLogView));
        }
    }
}
