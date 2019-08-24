using System;
using System.Threading.Tasks;
using Prism.Interactivity.InteractionRequest;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    public interface IAsyncWindowRequest
    {
        Task Raise( INotification notification );
    }
}
