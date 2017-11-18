using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// MainPanel のビューモデルを定義します。
    /// </summary>
    public class MainPanelViewModel : ExtendedViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand logoutButtonCommand;
        private EventHandler logoutButtonClick;


        // 公開プロパティ

        /// <summary>
        /// 親ウィンドウにあたるMainWindowのビューモデルが存在している場合は、取得または設定します。
        /// </summary>
        public MainWindowViewModel ParentWindowViewModel
        {
            get => this.GetBindingValue<MainWindowViewModel>(nameof(this.ParentWindowViewModel));
            set => this.SetBindingValue(nameof(this.ParentWindowViewModel), value);
        }


        // 公開プロパティ :: コマンド

        /// <summary>
        /// ログアウトボタンがクリックされたときのコマンドを定義します。
        /// </summary>
        public ICommand LogoutButtonCommand
        {
            get => this.logoutButtonCommand;
        }


        // 公開イベント

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler LogoutButtonClick
        {
            add => this.logoutButtonClick += value;
            remove => this.logoutButtonClick -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい MainPanelViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public MainPanelViewModel()
        {
            this.logoutButtonCommand =
                new DelegateCommand(param => this.logoutButtonClick?.Invoke(this, new EventArgs()));
        }
    }
}
