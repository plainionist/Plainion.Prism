using System;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    public class AsyncWindowRequestFactory : IAsyncWindowRequestFactory
    {
        public IAsyncWindowRequest CreateForView( Type windowContent )
        {
            return new AsyncWindowRequest( windowContent );
        }
    }
}
