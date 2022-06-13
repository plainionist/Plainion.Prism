using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using Plainion.Prism.Interactivity.InteractionRequest;
using Plainion.Prism.Interactivity;
using Prism.Interactivity;

namespace Plainion.Prism.Interactivity
{
    [DefaultProperty( "WindowContent" ), ContentProperty( "WindowContent" )]
    public class PopupViewAction : PopupWindowAction
    {
        private Window myWindow;

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
            myWindow = base.GetWindow( notification );

            if( UseNotificationContentAsDataContext )
            {
                myWindow.DataContext = notification.Content;
            }

            if (IsIndependent)
            {
                myWindow.Owner = null;
            }

            EventHandler handler = null;
            handler = (o, e) =>
                {
                    myWindow.Closed -= handler;
                    myWindow = null;
                };
            myWindow.Closed += handler;

            return myWindow;
        }

        protected override void Invoke(object parameter)
        {
            // in case it is already open - bring it to front
            if (myWindow != null)
            {
                myWindow.Activate();
            }

            base.Invoke(parameter);
        }
    }
}
