using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models.Elements;

namespace FFManager.Models
{
    /// <summary>
    /// 現在対応しているサービスを表します。
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// サービス名を取得します。
        /// </summary>
        string ServiceName
        {
            get;
        }

        /// <summary>
        /// サービスのURLを取得します。
        /// </summary>
        Uri Url
        {
            get;
        }

        /*
        /// <summary>
        /// アカウントを認証を取得します。
        /// </summary>
        /// <returns>認証に失敗、あるいは中断した場合は、Taskの結果としてnullを返します。</returns>
        /// <param name="parameters"></param>
        /// <remarks>このメソッドは、明示的なインターフェイスの実装により定義され、また、同名のメソッドで詳細な型が確定した適切な戻り値を返すメソッドを別途定義されることが理想です。</remarks>
        Task<IServiceAccount<IService>> AuthorizeAsync(AuthorizeParameter parameters);
        */

        /// <summary>
        /// 認証に利用するコンテキストを取得します。
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        AuthorizeContext GetAuthorizeContext(AuthorizeParameter parameter);
    }
}
