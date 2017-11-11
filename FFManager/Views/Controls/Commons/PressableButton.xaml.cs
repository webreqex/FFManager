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
    public partial class PressableButton : UserControl
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

        // Using a DependencyProperty as the backing store for Forecolor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForecolorProperty =
            DependencyProperty.Register("Forecolor", typeof(Brush), typeof(self), new PropertyMetadata(Brushes.Black, (d, e) =>
            {
                (d as self).MainTextBlock.Foreground = (Brush)e.NewValue;
            }));




        // コンストラクタ

        /// <summary>
        /// 新しい PressableButton クラスのインスタンスを初期化します。
        /// </summary>
        public PressableButton()
        {
            InitializeComponent();
        }


    }
}
