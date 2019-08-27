using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class ComplexCustomViewView : UserControl
    {
        public ComplexCustomViewView( ComplexCustomViewViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
