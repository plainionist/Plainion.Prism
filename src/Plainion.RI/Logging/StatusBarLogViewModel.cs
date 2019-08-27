using Plainion.Logging;
using Prism.Mvvm;

namespace Plainion.RI.Logging
{
    class StatusBarLogViewModel : BindableBase, ILoggingSink
    {
        private CustomLogEntry myLastLog;

        public CustomLogEntry LastLog
        {
            get { return myLastLog; }
            private set { SetProperty( ref myLastLog, value ); }
        }

        public void Write( ILogEntry entry )
        {
            LastLog = ( CustomLogEntry )entry;
        }
    }
}
