using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class DefaultWindowWithViewModelAsContentView : UserControl
    {
        public DefaultWindowWithViewModelAsContentView( DefaultWindowWithViewModelAsContentViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
