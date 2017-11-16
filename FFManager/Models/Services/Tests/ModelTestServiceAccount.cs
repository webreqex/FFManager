using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models.Bases;

namespace FFManager.Models.Services.Tests
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelTestServiceAccount : ServiceAccountBase<ModelTestService>
    {
        // 非公開フィールド
        private string clientId;


        // 公開プロパティ


        // コンストラクタ

        /// <summary>
        /// 新しい ModelTestServiceAccount クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public ModelTestServiceAccount(string clientId, string name, string id)
            : base(name, id, id, "modeltest")
        {
            this.clientId = clientId;
        }


        // 限定公開メソッド
        
        protected override Task<int> OnApplyUpdatedRelationAsync()
        {
            throw new NotImplementedException();
        }

        protected override Task<RelationAccountCollection<ModelTestService>> OnGetRelatedAccountsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
