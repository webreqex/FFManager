using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models;
using FFManager.Models.Services.Twitter;

namespace FFManager.Controller
{
    public class MainController
    {
        // 非公開フィールド
        private ApplicationState state;
        private IServiceAccount<IService> currentAccount;
        

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


        // コンストラクタ

        /// <summary>
        /// 新しい MainController クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="parameters"></param>
        public MainController(ControllerInitializeParameter parameters)
        {

        }
    }
}
