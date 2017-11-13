using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FFManager.Views.Behaviors
{
    public class WindowStateAttachedBehavior
    {
        public static WindowState GetState(DependencyObject obj)
        {
            return (WindowState)obj.GetValue(StateProperty);
        }

        public static void SetState(DependencyObject obj, WindowState value)
        {
            obj.SetValue(StateProperty, value);
        }

        public static readonly DependencyProperty StateProperty =
            DependencyProperty.RegisterAttached(
                "State",
                typeof(WindowState),
                typeof(WindowStateAttachedBehavior),
                new PropertyMetadata(WindowState.Normal, OnStateChanged));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var win = d as Window;
            if (win == null)
            {
                // Window以外のコントロールにこの添付ビヘイビアが付けられていた場合は、
                // コントロールの属しているWindowを取得
                win = Window.GetWindow(d);
            }
            
            win.WindowState = GetState(d);
        }
    }
}
