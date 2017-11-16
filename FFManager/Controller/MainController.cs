using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models;
using FFManager.Models.Services.Twitter;

namespace FFManager.Controller
{
    /// <summary>
    /// コントローラクラスを定義します．
    /// </summary>
    public class MainController
    {
        // 非公開フィールド
        private ApplicationState state;
        private IServiceAccount<IService> currentAccount;

        private EventHandler<ChangeStateEventArgs> changeState;


        // 公開プロパティ

        /// <summary>
        /// アプリケーションの現在の状態を取得します．
        /// </summary>
        public ApplicationState State
        {
            get => this.state;
        }

        /// <summary>
        /// 現在利用中のアカウントを取得します．
        /// ログインしていない場合は，nullを示します．
        /// </summary>
        public IServiceAccount<IService> CurrentAccount
        {
            get => this.currentAccount;
        }


        // 公開イベント

        /// <summary>
        /// State が変化した際に発生します．
        /// </summary>
        public event EventHandler<ChangeStateEventArgs> ChangeState
        {
            add => this.changeState += value;
            remove => this.changeState -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい MainController クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="parameters"></param>
        public MainController(ControllerInitializeParameter parameters)
        {
            this.currentAccount = null;
            this.state = ApplicationState.ChoiceLoginAccount;
        }


        // 非公開メソッド

        private void RaiseChangeStateEventArgs(ChangeStateEventArgs e)
        {
            // nullでなければ実行
            this.changeState?.Invoke(this, e);
        }


        // その他有象無象

        public class ChangeStateEventArgs
        {

        }
    }
}
