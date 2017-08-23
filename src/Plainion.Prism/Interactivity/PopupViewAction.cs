using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;

namespace Plainion.Prism.Interactivity
{
    [DefaultProperty( "WindowContent" ), ContentProperty( "WindowContent" )]
    public class PopupViewAction : PopupWindowAction
    {
        public static readonly DependencyProperty UseNotificationContentAsDataContextProperty = DependencyProperty.Register(
            "UseNotificationContentAsDataContext", typeof( bool ), typeof( PopupViewAction ), new PropertyMetadata( null ) );

        public bool UseNotificationContentAsDataContext
        {
            get { return ( bool )GetValue( UseNotificationContentAsDataContextProperty ); }
            set { SetValue( UseNotificationContentAsDataContextProperty, value ); }
        }

        /// <summary>
        /// When set the owner of the popup window is NOT set.
        /// </summary>
        public static readonly DependencyProperty IsIndependentProperty = DependencyProperty.Register(
            "IsIndependent", typeof(bool), typeof(PopupViewAction), new PropertyMetadata(null));

        public bool IsIndependent
        {
            get { return (bool)GetValue(IsIndependentProperty); }
            set { SetValue(IsIndependentProperty, value); }
        }

        protected override Window GetWindow( INotification notification )
        {
            var window = base.GetWindow( notification );

            if( UseNotificationContentAsDataContext )
            {
                window.DataContext = notification.Content;
            }

            if (IsIndependent)
            {
                window.Owner = null;
            }

            return window;
        }
    }
}
