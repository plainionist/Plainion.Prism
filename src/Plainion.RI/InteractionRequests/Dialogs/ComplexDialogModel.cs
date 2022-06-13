﻿using System;
using System.Windows.Input;
using Plainion.Prism.Interactivity.InteractionRequest;
using Prism.Commands;
using Prism.Mvvm;

namespace Plainion.RI.InteractionRequests.Dialogs
{
    public class ComplexDialogModel : BindableBase, IInteractionRequestAware
    {
        private Model myModel;

        /// <summary>
        /// Usually we can assume that for complex UI we have a complex ViewModel with dependencies.
        /// Ideally we let MEF create it in order to resolve dependencies automatically.
        /// </summary>
        public ComplexDialogModel( Model model )
        {
            myModel = model;

            ApplyCommand = new DelegateCommand( OnApply );
            OkCommand = new DelegateCommand( OnOk );
            CancelCommand = new DelegateCommand( OnCancel );
        }

        public ICommand ApplyCommand { get; private set; }

        private void OnApply()
        {
            myModel.JustMySampleState = "Apply";
        }

        public ICommand OkCommand { get; private set; }

        private void OnOk()
        {
            myModel.JustMySampleState = "Ok";
            FinishInteraction();
        }

        public ICommand CancelCommand { get; private set; }

        private void OnCancel()
        {
            myModel.JustMySampleState = "Cancel";
            FinishInteraction();
        }

        public Action FinishInteraction { get; set; }

        public INotification Notification { get; set; }
    }
}
