using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models;

namespace FFManager.Controller
{
    using self = ControllerInitializeParameter;

    /// <summary>
    /// MainControllerの初期化用パラメータをコンテナ化します．
    /// </summary>
    public class ControllerInitializeParameter
    {
        // 非公開フィールド
        private ApplicationState state;
        private ICollection<IService> services;
        private ICollection<IServiceAccount<IService>> serviceAccounts;
        private int currentAccountIndex;


        // 公開プロパティ

        /// <summary>
        /// 開始時の ApplicationState を取得または，設定します．
        /// デフォルトの値は， ChoiceLoginAccount です．
        /// </summary>
        public ApplicationState State
        {
            get => this.state;
            set => this.state = value;
        }

        /// <summary>
        /// 利用可能なサービスの一覧を示すコレクションを取得または，設定します．
        /// 最低限１つ以上指定されている必要があります．
        /// </summary>
        public ICollection<IService> Services
        {
            get => this.services;
            set => this.services = value;
        }

        /// <summary>
        /// アカウントのコレクションを取得または，設定します．
        /// アカウントのコレクションが未作成の場合は，nullではなく空のコレクションを示すようにしてください．
        /// </summary>
        public ICollection<IServiceAccount<IService>> ServiceAccounts
        {
            get => this.serviceAccounts;
            set => this.serviceAccounts = value;
        }

        /// <summary>
        /// ログイン済みの場合は，ServiceAccountsのうち利用中のアカウントを示すアイテムのインデックス番号を取得または，設定します．
        /// ログイン済みでない場合は，-1を示すようにしてください．
        /// </summary>
        public int CurrentAccountIndex
        {
            get => this.currentAccountIndex;
            set => this.currentAccountIndex = value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい ControllerInitializeParameter クラスのインスタンスを初期化します．
        /// </summary>
        public ControllerInitializeParameter()
        {
            this.state = ApplicationState.ChoiceLoginAccount;
            this.services = new IService[0];
            this.serviceAccounts = new IServiceAccount<IService>[0];
            this.currentAccountIndex = -1;
        }


        // 公開静的メソッド

        /// <summary>
        /// 指定したファイルからパラメータをロードします．
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static self CreateFrom(string path)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
