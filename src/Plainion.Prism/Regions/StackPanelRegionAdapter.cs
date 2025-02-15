using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using Prism.Navigation.Regions;

namespace Plainion.Prism.Regions
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>, IRegionAdapter
    {
        public StackPanelRegionAdapter( IRegionBehaviorFactory factory )
            : base( factory )
        {
        }

        protected override void Adapt( IRegion region, StackPanel regionTarget )
        {
            region.Views.CollectionChanged += ( s, e ) =>
                {
                    if( e.Action == NotifyCollectionChangedAction.Add )
                    {
                        foreach( FrameworkElement element in e.NewItems )
                        {
                            regionTarget.Children.Add( element );
                        }
                    }
                };
        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
