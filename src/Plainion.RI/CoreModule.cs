using Plainion.RI.InteractionRequests;
using Plainion.RI.InteractionRequests.Dialogs;
using Plainion.RI.Logging;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Plainion.RI
{
    class CoreModule : IModule
    {
        private IRegionManager myRegionManager;

        public CoreModule(IRegionManager regionManager)
        {
            myRegionManager = regionManager;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewAsContentView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewModelAsContentView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(CustomNotificationView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(ComplexCustomViewView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnContentControlView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowActionView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowContentControlView));
            myRegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionWithPopupWindowActionExtensionsView));

            myRegionManager.RegisterViewWithRegion("RegionOnContentControlView", typeof(ComplexDialog));
            myRegionManager.RegisterViewWithRegion("RegionOnPopupWindowActionView", typeof(ComplexDialog));
            myRegionManager.RegisterViewWithRegion("RegionOnPopupWindowContentControlView", typeof(ComplexDialog));
            myRegionManager.RegisterViewWithRegion("RegionWithPopupWindowActionExtensionsView", typeof(ComplexDialog));

            myRegionManager.RegisterViewWithRegion(RegionNames.StatusBar, typeof(StatusBarLogView));
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
