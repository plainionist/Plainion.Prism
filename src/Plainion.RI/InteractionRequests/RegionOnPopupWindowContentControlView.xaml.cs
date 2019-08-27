using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class RegionOnPopupWindowContentControlView : UserControl
    {
        public RegionOnPopupWindowContentControlView( RegionOnPopupWindowContentControlViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
