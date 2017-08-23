using System.ComponentModel.Composition;
using Plainion.RI.InteractionRequests;
using Plainion.RI.InteractionRequests.Dialogs;
using Plainion.RI.Logging;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;

namespace Plainion.RI
{
    [ModuleExport(typeof(CoreModule))]
    class CoreModule : IModule
    {
        [Import]
        public IRegionManager RegionManager { get; private set; }

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewAsContentView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(DefaultWindowWithViewModelAsContentView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(CustomNotificationView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(ComplexCustomViewView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnContentControlView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowActionView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionOnPopupWindowContentControlView));
            RegionManager.RegisterViewWithRegion(RegionNames.Interactivity, typeof(RegionWithPopupWindowActionExtensionsView));

            RegionManager.RegisterViewWithRegion("RegionOnContentControlView", typeof(ComplexDialog));
            RegionManager.RegisterViewWithRegion("RegionOnPopupWindowActionView", typeof(ComplexDialog));
            RegionManager.RegisterViewWithRegion("RegionOnPopupWindowContentControlView", typeof(ComplexDialog));
            RegionManager.RegisterViewWithRegion("RegionWithPopupWindowActionExtensionsView", typeof(ComplexDialog));

            RegionManager.RegisterViewWithRegion(RegionNames.StatusBar, typeof(StatusBarLogView));
        }
    }
}
