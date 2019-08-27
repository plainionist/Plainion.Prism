using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class RegionOnPopupWindowActionView : UserControl
    {
        public RegionOnPopupWindowActionView( RegionOnPopupWindowActionViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
