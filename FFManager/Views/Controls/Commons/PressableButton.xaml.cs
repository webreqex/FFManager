using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FFManager.Views.Controls.Commons
{
    using self = PressableButton;

    /// <summary>
    /// PressableButton.xaml の相互作用ロジック
    /// </summary>
    public partial class PressableButton : UserControl, ICommandSource
    {
        // 依存関係プロパティ
        
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(self), new PropertyMetadata("", (d, e) =>
            {
                (d as self).MainTextBlock.Text = (string)e.NewValue;
            }));


        
        public Brush Forecolor
        {
            get { return (Brush)GetValue(ForecolorProperty); }
            set { SetValue(ForecolorProperty, value); }
        }

        public static readonly DependencyProperty ForecolorProperty =
            DependencyProperty.Register("Forecolor", typeof(Brush), typeof(self), new PropertyMetadata(Brushes.Black, (d, e) =>
            {
                (d as self).MainTextBlock.Foreground = (Brush)e.NewValue;
            }));


        
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(self), new PropertyMetadata(null));


        
        public Object CommandParameter
        {
            get { return (Object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(Object), typeof(self), new PropertyMetadata(null));

        

        public IInputElement CommandTarget
        {
            get { return (IInputElement)GetValue(CommandTargetProperty); }
            set { SetValue(CommandTargetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CommandTarget.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandTargetProperty =
            DependencyProperty.Register("CommandTarget", typeof(IInputElement), typeof(self), new PropertyMetadata(null));
        


        // コンストラクタ

        /// <summary>
        /// 新しい PressableButton クラスのインスタンスを初期化します。
        /// </summary>
        public PressableButton()
        {
            InitializeComponent();
        }


        // 限定公開メソッド

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);

            var command = this.Command;
            var parameter = this.CommandParameter;
            var target = this.CommandTarget;

            var routedCommand = command as RoutedCommand;
            if (routedCommand != null && routedCommand.CanExecute(parameter, target))
                routedCommand.Execute(parameter, target);
            else if (command != null && command.CanExecute(parameter))
                command.Execute(parameter);
        }
    }
}
