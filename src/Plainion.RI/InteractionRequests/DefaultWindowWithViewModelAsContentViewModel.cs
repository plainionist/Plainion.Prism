﻿using System.Windows.Input;
using Plainion.Prism.Interactivity.InteractionRequest;
using Prism.Commands;
using Prism.Mvvm;

namespace Plainion.RI.InteractionRequests
{
    class DefaultWindowWithViewModelAsContentViewModel : BindableBase
    {
        private string myResponse;

        public DefaultWindowWithViewModelAsContentViewModel()
        {
            ShowConfirmationCommand = new DelegateCommand( OnShowConfirmation );
            ConfirmationRequest = new InteractionRequest<IConfirmation>();
        }

        public ICommand ShowConfirmationCommand { get; private set; }

        private void OnShowConfirmation()
        {
            var confirmation = new Confirmation();
            confirmation.Title = "Really?";

            // TODO: unfort. i couldnt find a way to provide a DataTemplate for ConfirmationContent to the new window
            confirmation.Content = new ConfirmationContent( "Here goes the question, doesn't it?" );

            ConfirmationRequest.Raise( confirmation, c => Response = c.Confirmed ? "yes" : "no" );
        }

        public InteractionRequest<IConfirmation> ConfirmationRequest { get; private set; }

        public string Response
        {
            get { return myResponse; }
            set { SetProperty( ref myResponse, value ); }
        }
    }

    class ConfirmationContent
    {
        public ConfirmationContent( string question )
        {
            Question = question;
        }

        public string Question { get; private set; }
    }
}
