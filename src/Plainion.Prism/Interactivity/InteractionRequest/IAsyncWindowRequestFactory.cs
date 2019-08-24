using System;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    public interface IAsyncWindowRequestFactory
    {
        IAsyncWindowRequest CreateForView( Type windowContent );
    }
}
