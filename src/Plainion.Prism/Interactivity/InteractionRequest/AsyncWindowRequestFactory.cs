using System;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    public class AsyncWindowRequestFactory : IAsyncWindowRequestFactory
    {
        public IAsyncWindowRequest CreateForView( Type windowContent )
        {
            return new AsyncWindowRequest( windowContent );
        }
    }
}
