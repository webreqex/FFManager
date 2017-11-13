using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FFManager.Views.Controls
{
    using self = RegisteredAccountItem;

    /// <summary>
    /// RegisteredAccountItem.xaml の相互作用ロジック
    /// </summary>
    public partial class RegisteredAccountItem : UserControl
    {
        // 依存関係プロパティ
        
        public string AccountNameText
        {
            get { return (string)GetValue(AccountNameTextProperty); }
            set { SetValue(AccountNameTextProperty, value); }
        }

        public static readonly DependencyProperty AccountNameTextProperty =
            DependencyProperty.Register("AccountNameText", typeof(string), typeof(self), new PropertyMetadata("", onAccountNameTextChanged));

        private static void onAccountNameTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((self)d).AccountNameTextBlock.Text = e.NewValue as string;
        }


        public string ServiceNameText
        {
            get { return (string)GetValue(ServiceNameTextProperty); }
            set { SetValue(ServiceNameTextProperty, value); }
        }
        
        public static readonly DependencyProperty ServiceNameTextProperty =
            DependencyProperty.Register("ServiceNameText", typeof(string), typeof(self), new PropertyMetadata("", onServiceNameTextChanged));

        private static void onServiceNameTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((self)d).ServiceTextBlock.Text = e.NewValue as string;
        }
        

        public ImageSource AccountIcon
        {
            get { return (ImageSource)GetValue(AccountIconProperty); }
            set { SetValue(AccountIconProperty, value); }
        }
        
        public static readonly DependencyProperty AccountIconProperty =
            DependencyProperty.Register("AccountIcon", typeof(ImageSource), typeof(self), new PropertyMetadata(null, onAccountIconChanged));

        private static void onAccountIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((self)d).IconImage.Source = e.NewValue as ImageSource;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい RegisteredAccountItem クラスのインスタンスを初期化します。
        /// </summary>
        public RegisteredAccountItem()
        {
            InitializeComponent();
        }
    }
}
