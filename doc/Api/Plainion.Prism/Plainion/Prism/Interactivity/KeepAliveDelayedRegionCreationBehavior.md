
# Plainion.Prism.Interactivity.KeepAliveDelayedRegionCreationBehavior

**Namespace:** Plainion.Prism.Interactivity

**Assembly:** Plainion.Prism

This DelayedRegionCreationBehavior is required if you want to put regions to non-FrameworkElement objects (like PopupWindowAction). In this case the instance of the DelayedRegionCreationBehavior is only referenced by RegionManager.UpdatingRegions event which internally uses WeakReferences. This means if GC catched you before RegionManager.UpdateRegions() was called your region will never be updated.


## Constructors

### Constructor(Prism.Regions.RegionAdapterMappings regionAdapterMappings)


## Methods

### Prism.Regions.IRegion CreateRegion(System.Windows.DependencyObject targetElement,System.String regionName)
