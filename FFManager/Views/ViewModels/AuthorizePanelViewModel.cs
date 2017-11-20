using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// AuthorizePanelのビューモデルを定義します。
    /// </summary>
    public class AuthorizePanelViewModel : ExtendedViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand cancelButtonCommand;
        private EventHandler<CommandEventArgs> cancelButtonClick;


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
        /// キャンセルボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand CancelButtonCommand
        {
            get => this.cancelButtonCommand;
        }


        // 公開イベント

        /// <summary>
        /// キャンセルボタンがクリックされたときに発生します。
        /// </summary>
        public event EventHandler<CommandEventArgs> CancelButtonClick
        {
            add => this.cancelButtonClick += value;
            remove => this.cancelButtonClick -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい AuthorizePanelViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public AuthorizePanelViewModel()
        {
            this.cancelButtonCommand =
                new DelegateCommand(param => this.cancelButtonClick?.Invoke(this, new CommandEventArgs()));
        }


        // 内部メンバ

        /// <summary>
        /// 
        /// </summary>
        public class CommandEventArgs
        {

        }
    }
}
