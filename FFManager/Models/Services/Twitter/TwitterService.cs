using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreTweet;

using FFManager.Models.Bases;
using FFManager.Models.Elements;

namespace FFManager.Models.Services.Twitter
{
    /// <summary>
    /// 
    /// </summary>
    public class TwitterService : ServiceBase
    {
        // 非公開フィールド
        private string consumerKey;
        private string consumerSecret;


        // 公開プロパティ


        // コンストラクタ

        /// <summary>
        /// 新しい TwitterService クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        public TwitterService(string consumerKey, string consumerSecret)
            : base("Twitter", new Uri("https://twitter.com"))
        {
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
        }


        // 限定公開メソッド

        protected override Task<IServiceAccount<IService>> OnAuthorizeAsync(AuthorizeParameter parameters)
        {
            return null;
        }
    }
}
