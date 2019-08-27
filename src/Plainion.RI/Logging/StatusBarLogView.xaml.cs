using System.Windows.Controls;

namespace Plainion.RI.Logging
{
    partial class StatusBarLogView : UserControl
    {
        public StatusBarLogView( StatusBarLogViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
