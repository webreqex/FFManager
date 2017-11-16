using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models.Elements;

namespace FFManager.Models.Bases
{
    /// <summary>
    /// すべてのサービスに共通する機能を定義します。
    /// </summary>
    public abstract class ServiceBase : IService
    {
        // 非公開フィールド
        private string serviceName;
        private Uri url;


        // 限定公開フィールド


        // 公開プロパティ

        /// <summary>
        /// サービス名を取得します。
        /// </summary>
        public string ServiceName
        {
            get => this.serviceName;
        }

        /// <summary>
        /// サービスのURLを取得します。
        /// </summary>
        public Uri Url
        {
            get => this.url;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい ServiceBase クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="url"></param>
        public ServiceBase(string serviceName, Uri url)
        {
            this.serviceName = serviceName;
            this.url = url;
        }


        // 限定公開メソッド

        /// <summary>
        /// アカウントを認証を取得する処理を実装します。
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns>認証に失敗、あるいは中断した場合は、Taskの結果としてnullを返します。</returns>
        protected abstract Task<IServiceAccount<IService>> OnAuthorizeAsync(AuthorizeParameter parameters);


        // 公開メソッド


        // 公開メソッド :: 明示的なインターフェイスの実装

        Task<IServiceAccount<IService>> IService.AuthorizeAsync(AuthorizeParameter parameters)
        {
            return this.OnAuthorizeAsync(parameters);
        }
    }
}
