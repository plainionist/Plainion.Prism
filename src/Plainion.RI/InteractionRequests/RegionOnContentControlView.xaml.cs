using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class RegionOnContentControlView : UserControl
    {
        public RegionOnContentControlView( RegionOnContentControlViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
