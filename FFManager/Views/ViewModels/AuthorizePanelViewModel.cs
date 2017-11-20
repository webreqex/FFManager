using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

using FFManager.Controller;
using FFManager.Views.ViewModels.Bases;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// AuthorizePanelのビューモデルを定義します。
    /// </summary>
    public class AuthorizePanelViewModel : SubPanelViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand cancelButtonCommand;
        private EventHandler<CommandEventArgs> cancelButtonClick;


        // 公開プロパティ


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


        // 非公開メソッド
        



        // 内部メンバ

        /// <summary>
        /// 
        /// </summary>
        public class CommandEventArgs
        {

        }
    }
}
