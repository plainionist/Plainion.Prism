using System.Threading.Tasks;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    public interface IAsyncWindowRequest
    {
        Task Raise( INotification notification );
    }
}
