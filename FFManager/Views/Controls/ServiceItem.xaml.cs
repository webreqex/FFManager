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
    using self = ServiceItem;

    /// <summary>
    /// ServiceItem.xaml の相互作用ロジック
    /// </summary>
    public partial class ServiceItem : UserControl
    {
        // 依存関係プロパティ
        
        public string ServiceName
        {
            get { return (string)GetValue(ServiceNameProperty); }
            set { SetValue(ServiceNameProperty, value); }
        }
        
        public static readonly DependencyProperty ServiceNameProperty =
            DependencyProperty.Register("ServiceName", typeof(string), typeof(self), new PropertyMetadata("", updateServiceName));

        
        public string ServiceUrl
        {
            get { return (string)GetValue(ServiceUrlProperty); }
            set { SetValue(ServiceUrlProperty, value); }
        }
        
        public static readonly DependencyProperty ServiceUrlProperty =
            DependencyProperty.Register("ServiceUrl", typeof(string), typeof(self), new PropertyMetadata("", updateServiceUrl));

        
        public ImageSource ServiceIcon
        {
            get { return (ImageSource)GetValue(ServiceIconProperty); }
            set { SetValue(ServiceIconProperty, value); }
        }
        
        public static readonly DependencyProperty ServiceIconProperty =
            DependencyProperty.Register("ServiceIcon", typeof(ImageSource), typeof(self), new PropertyMetadata(null));

        

        // コンストラクタ

        /// <summary>
        /// 新しい ServiceItem クラスのインスタンスを初期化します。
        /// </summary>
        public ServiceItem()
        {
            InitializeComponent();
        }


        // 非公開メソッド
        
        private static void updateServiceName(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((self)d).ServiceNameTextBlock.Text = e.NewValue as string;
        }

        private static void updateServiceUrl(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((self)d).ServiceUrlTextBlock.Text = e.NewValue as string;
        }
    }
}
