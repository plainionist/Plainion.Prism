using System.Windows;
using System.Windows.Input;
using Plainion.Logging;

namespace Plainion.RI
{
    partial class Shell : Window
    {
        private static readonly ILogger myLogger = LoggerFactory.GetLogger( typeof( ShellViewModel ) );

        public Shell( ShellViewModel viewModel )
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        private void Window_PreviewMouseMove( object sender, System.Windows.Input.MouseEventArgs e )
        {
            myLogger.Notice( "You hovered over '{0}'", Mouse.DirectlyOver.GetType() );
        }
    }
}
