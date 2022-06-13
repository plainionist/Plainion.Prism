﻿using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Plainion.Prism.Interactivity.InteractionRequest;
using Prism.Commands;
using Prism.Mvvm;

namespace Plainion.RI.InteractionRequests
{
    class DefaultWindowWithViewAsContentViewModel : BindableBase
    {
        private string myResponse;

        public DefaultWindowWithViewAsContentViewModel()
        {
            ShowConfirmationCommand = new DelegateCommand( OnShowConfirmation );
            ConfirmationRequest = new InteractionRequest<IConfirmation>();
        }

        public ICommand ShowConfirmationCommand { get; private set; }

        private void OnShowConfirmation()
        {
            var confirmation = new Confirmation();
            confirmation.Title = "Really?";

            confirmation.Content = new Border
            {
                BorderBrush = Brushes.Green,
                BorderThickness = new System.Windows.Thickness( 2 ),
                Padding = new System.Windows.Thickness( 10 ),
                Child = new TextBlock { Text = "Here goes the question, doesn't it?" }
            };

            ConfirmationRequest.Raise( confirmation, c => Response = c.Confirmed ? "yes" : "no" );
        }

        public InteractionRequest<IConfirmation> ConfirmationRequest { get; private set; }

        public string Response
        {
            get { return myResponse; }
            set { SetProperty( ref myResponse, value ); }
        }
    }
}
