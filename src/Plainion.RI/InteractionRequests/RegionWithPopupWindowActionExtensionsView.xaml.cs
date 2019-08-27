using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class RegionWithPopupWindowActionExtensionsView : UserControl
    {
        public RegionWithPopupWindowActionExtensionsView( RegionWithPopupWindowActionExtensionsViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
