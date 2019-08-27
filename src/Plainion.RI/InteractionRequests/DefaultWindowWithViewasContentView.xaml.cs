using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class DefaultWindowWithViewAsContentView : UserControl
    {
        public DefaultWindowWithViewAsContentView( DefaultWindowWithViewAsContentViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
