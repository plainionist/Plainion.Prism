using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests
{
    partial class CustomNotificationView : UserControl
    {
        public CustomNotificationView( CustomNotificationViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
