﻿using System.Windows.Controls;

namespace Plainion.RI.InteractionRequests.Dialogs
{
    partial class ComplexDialog : UserControl
    {
        public ComplexDialog()
        {
            InitializeComponent();

            // we have to create and pass the viewmodel outside because of the viewmodel's dependencies the view
            // cannot just create it here
        }

        /// <summary>
        /// Usually of course we would have only one constructor but in order to keep the sample small ...
        /// </summary>
        public ComplexDialog(ComplexDialogModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
