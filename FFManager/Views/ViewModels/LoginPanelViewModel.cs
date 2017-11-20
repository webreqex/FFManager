using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

using FFManager.Controller;

namespace FFManager.Views.ViewModels
{
    public class LoginPanelViewModel : ExtendedViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand cancelButtonCommand;
        private EventHandler<CommandEventArgs> cancelButtonClick;
        private DelegateCommand authorizeButtonCommand;
        private EventHandler<CommandEventArgs> authorizeButtonClick;


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

        /// <summary>
        /// 新規認証ボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand AuthorizeButtonCommand
        {
            get => this.authorizeButtonCommand;
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

        /// <summary>
        /// 新規認証ボタンがクリックされたときに発生します。
        /// </summary>
        public event EventHandler<CommandEventArgs> AuthorizeButtonClick
        {
            add => this.authorizeButtonClick += value;
            remove => this.authorizeButtonClick -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい LoginPanelViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public LoginPanelViewModel()
        {
            this.cancelButtonCommand =
                new DelegateCommand(param => this.cancelButtonClick?.Invoke(this, new CommandEventArgs()));
            this.authorizeButtonCommand =
                new DelegateCommand(param => this.authorizeButtonClick?.Invoke(this, new CommandEventArgs()));
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
