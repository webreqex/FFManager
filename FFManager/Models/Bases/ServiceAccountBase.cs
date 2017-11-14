using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models.Bases
{
    /// <summary>
    /// すべてのサービスのアカウントについて共通する機能を定義します。
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    public abstract class ServiceAccountBase<TService> : IServiceAccount<TService> where TService : IService
    {
        // 非公開フィールド
        private string name;
        private string id;
        private string internalId;
        private string accountTypeId;


        // 公開プロパティ

        /// <summary>
        /// アカウント名を取得します。
        /// </summary>
        public string Name
        {
            get => this.name;
        }

        /// <summary>
        /// ID名を取得します。
        /// </summary>
        public string Id
        {
            get => this.id;
        }

        /// <summary>
        /// 内部IDを取得します。存在しない場合は、nullを表します。
        /// </summary>
        public string InternalId
        {
            get => this.internalId;
        }


        // 公開プロパティ :: インターフェイスの明示的な実装
        
        string IAccount.AccountTypeId
        {
            get => this.accountTypeId;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい ServiceAccountBase クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="name">アカウント名</param>
        /// <param name="id">ID名</param>
        /// <param name="internalId">内部ID。存在しない場合は、nullを指定します。</param>
        /// <param name="accountTypeId">アカウントの実装タイプを判定するための文字列</param>
        public ServiceAccountBase(string name, string id, string internalId, string accountTypeId)
        {
            this.name = name;
            this.id = id;
            this.internalId = internalId;
            this.accountTypeId = accountTypeId;
        }


        // 限定公開メソッド

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected abstract Task<RelationAccountCollection<TService>> OnGetRelatedAccountsAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected abstract Task<int> OnApplyUpdatedRelationAsync();


        // 公開メソッド :: 明示的なインターフェイスの実装

        Task<RelationAccountCollection<TService>> IServiceAccount<TService>.GetRelatedAccountsAsync()
        {
            return this.OnGetRelatedAccountsAsync();
        }

        Task<int> IServiceAccount<TService>.ApplyUpdatedRelationAsync()
        {
            return this.OnApplyUpdatedRelationAsync();
        }

    }
}
