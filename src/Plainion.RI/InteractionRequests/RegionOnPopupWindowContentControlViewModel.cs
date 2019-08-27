using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace Plainion.RI.InteractionRequests
{
    class RegionOnPopupWindowContentControlViewModel : BindableBase
    {
        public RegionOnPopupWindowContentControlViewModel( Model model )
        {
            Model = model;

            ShowConfirmationCommand = new DelegateCommand( OnShowConfirmation );
            ConfirmationRequest = new InteractionRequest<INotification>();
        }

        public Model Model { get; private set; }

        public ICommand ShowConfirmationCommand { get; private set; }

        private void OnShowConfirmation()
        {
            var notification = new Notification();
            notification.Title = "Really?";

            ConfirmationRequest.Raise( notification, n => { } );
        }

        public InteractionRequest<INotification> ConfirmationRequest { get; private set; }
    }
}
