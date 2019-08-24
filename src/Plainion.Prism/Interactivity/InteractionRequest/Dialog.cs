using System;
using Prism.Interactivity.InteractionRequest;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    public class Dialog : Confirmation, IDialog
    {
        public double? Width { get; set; }
        public double? Height { get; set; }
    }
}
