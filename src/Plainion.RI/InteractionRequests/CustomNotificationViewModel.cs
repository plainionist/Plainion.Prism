﻿using System;
using System.Windows.Input;
using Plainion.Prism.Interactivity.InteractionRequest;
using Prism.Commands;
using Prism.Mvvm;

namespace Plainion.RI.InteractionRequests
{
    class CustomNotificationViewModel : BindableBase
    {
        private string myResponse;

        public CustomNotificationViewModel()
        {
            ShowConfirmationCommand = new DelegateCommand( OnShowConfirmation );
            ConfirmationRequest = new InteractionRequest<YesNoCancelNotification>();
        }

        public ICommand ShowConfirmationCommand { get; private set; }

        private void OnShowConfirmation()
        {
            var confirmation = new YesNoCancelNotification( "Really?" );
            confirmation.Title = "Really?";

            ConfirmationRequest.Raise( confirmation, c => Response = c.Response.ToString() );
        }

        public InteractionRequest<YesNoCancelNotification> ConfirmationRequest { get; private set; }

        public string Response
        {
            get { return myResponse; }
            set { SetProperty( ref myResponse, value ); }
        }
    }

    public class YesNoCancelNotification : Notification, IInteractionRequestAware
    {
        public enum ResponseType
        {
            Cancel,
            Yes,
            No
        }

        public YesNoCancelNotification( string question )
        {
            Question = question;

            YesCommand = new DelegateCommand( () => OnConfirmed( ResponseType.Yes ) );
            NoCommand = new DelegateCommand( () => OnConfirmed( ResponseType.No ) );
            CancelCommand = new DelegateCommand( () => OnConfirmed( ResponseType.Cancel ) );

            Response = ResponseType.Cancel;
        }

        public string Question { get; private set; }

        public ResponseType Response { get; private set; }

        public ICommand YesCommand { get; private set; }

        public ICommand NoCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        private void OnConfirmed( ResponseType response )
        {
            Response = response;
            FinishInteraction();
        }

        public Action FinishInteraction { get; set; }

        public INotification Notification { get; set; }
    }
}
