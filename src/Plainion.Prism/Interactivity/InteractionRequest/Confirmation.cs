namespace Plainion.Prism.Interactivity.InteractionRequest
{
    /// <summary>
    /// Basic implementation of <see cref="IConfirmation"/>.
    /// </summary>
    public class Confirmation : Notification, IConfirmation
    {
        /// <summary>
        /// Gets or sets a value indicating that the confirmation is confirmed.
        /// </summary>
        public bool Confirmed { get; set; }
    }
}
