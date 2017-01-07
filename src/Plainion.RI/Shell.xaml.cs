using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;
using Plainion.Logging;

namespace Plainion.RI
{
    [Export]
    public partial class Shell : Window
    {
        private static readonly ILogger myLogger = LoggerFactory.GetLogger( typeof( ShellViewModel ) );

        [ImportingConstructor]
        internal Shell( ShellViewModel viewModel )
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
