
using System;

namespace Plainion.Prism.Interactivity.InteractionRequest
{
    [Obsolete("Prism 7 marked PopupWindowAction as obsolete. Use IDialogService instead")]
    public class SaveFileDialogNotification : FileDialogNotificationBase
    {
        /// <see cref="P:Microsoft.Win32.FileDialog.CreatePrompt"/>
        public bool? CreatePrompt
        {
            get;
            set;
        }

        /// <see cref="P:Microsoft.Win32.FileDialog.OverwritePrompt"/>
        public bool? OverwritePrompt
        {
            get;
            set;
        }
    }
}
