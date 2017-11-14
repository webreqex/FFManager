using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFManager.Models.Bases
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    public abstract class RelationAccountBase<TService> : IRelationAccount<TService> where TService : IService
    {
        // 非公開フィールド
        private IServiceAccount<TService> relatedOwner;
        private string name;
        private string id;
        private string internalId;


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


        // 公開プロパティ :: 明示的なインターフェイスの実装

        IServiceAccount<TService> IRelationAccount<TService>.RelatedOwner
        {
            get => this.relatedOwner;
        }
        
        
        // コンストラクタ

        /// <summary>
        /// 新しい RelationAccountBase クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="relatedOwner"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="internalId"></param>
        public RelationAccountBase(IServiceAccount<TService> relatedOwner, string name, string id, string internalId)
        {
            this.relatedOwner = relatedOwner;
            this.name = name;
            this.id = id;
            this.internalId = internalId;
        }
    }
}
