using System;
using Prism.Interactivity.InteractionRequest;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    interface IDialog : IConfirmation
    {
        double? Width { get; set; }
        double? Height { get; set; }
    }
}
