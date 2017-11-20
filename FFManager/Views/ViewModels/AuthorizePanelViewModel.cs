using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocusCommon.Windows.ViewModels;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// AuthorizePanelのビューモデルを定義します。
    /// </summary>
    public class AuthorizePanelViewModel : ExtendedViewModelBase
    {
        // 非公開フィールド
        

        // 公開プロパティ

        /// <summary>
        /// 親ウィンドウにあたるMainWindowのビューモデルが存在している場合は、取得または設定します。
        /// </summary>
        public MainWindowViewModel ParentWindowViewModel
        {
            get => this.GetBindingValue<MainWindowViewModel>(nameof(this.ParentWindowViewModel));
            set => this.SetBindingValue(nameof(this.ParentWindowViewModel), value);
        }
    }
}
