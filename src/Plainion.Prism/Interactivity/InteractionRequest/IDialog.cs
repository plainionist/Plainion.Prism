﻿namespace Plainion.Prism.Interactivity.InteractionRequest
{
    interface IDialog : IConfirmation
    {
        double? Width { get; set; }
        double? Height { get; set; }
    }
}
