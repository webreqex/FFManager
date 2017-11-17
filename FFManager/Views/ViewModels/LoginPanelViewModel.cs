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
        private MainWindowViewModel parentWindowViewModel;

        private EventHandler<CommandEventArgs> cancelButtonClick;

        private DelegateCommand cancelButtonCommand;


        // 公開プロパティ

        /// <summary>
        /// 親ウィンドウにあたるMainWindowのビューモデルが存在している場合は、取得または設定します。
        /// 存在しない場合は、nullを示します。
        /// このプロパティは Observable ではありません。
        /// </summary>
        public MainWindowViewModel ParentWindowViewModel
        {
            get => this.parentWindowViewModel;
            set => this.parentWindowViewModel = value;
        }


        // 公開プロパティ :: コマンド

        /// <summary>
        /// キャンセルボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand CancelButtonClickCommand
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
        /// 新しい LoginPanelViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public LoginPanelViewModel()
        {
            this.parentWindowViewModel = null;

            this.cancelButtonCommand = new DelegateCommand(param => this.cancelButtonClick?.Invoke(this, new CommandEventArgs()));
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
