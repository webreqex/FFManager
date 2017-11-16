using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models.Bases;
using FFManager.Models.Elements;

namespace FFManager.Models.Services.Tests
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelTestService : ServiceBase
    {
        // 非公開フィールド
        private string clientId;

        // コンストラクタ

        /// <summary>
        /// 新しい ModelTestService クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="clientId"></param>
        public ModelTestService(string clientId)
            : base("ModelTestService", new Uri("http://test.a32kita.tk/"))
        {
            this.clientId = clientId;
        }


        // 限定公開メソッド

        protected override Task<IServiceAccount<IService>> OnAuthorizeAsync(AuthorizeParameter parameters)
        {
            return Task.Run(async () =>
            {
                return (IServiceAccount<IService>)await this.AuthorizeAsync(parameters);
            });
        }


        // 公開メソッド

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<ModelTestServiceAccount> AuthorizeAsync(AuthorizeParameter parameters)
        {
            return Task.Run(() =>
            {
                return new ModelTestServiceAccount(this.clientId, "name", "id");
            });
        }
    }
}
