using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

using FFManager.Views.ViewModels.Bases;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// MainPanel のビューモデルを定義します。
    /// </summary>
    public class MainPanelViewModel : SubPanelViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand logoutButtonCommand;
        private EventHandler logoutButtonClick;


        // 公開プロパティ


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
