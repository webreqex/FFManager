using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models
{
    /// <summary>
    /// アプリケーションで管理する T (IService) のアカウントを表します。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IServiceAccount<T> : IAccount where T : IService
    {
        /// <summary>
        /// 現在このアカウントと関係のあるアカウントを取得します。
        /// </summary>
        /// <returns></returns>
        /// <remarks>このメソッドは、明示的なインターフェイスの実装により定義され、また、同名のメソッドで詳細な型が確定した適切な戻り値を返すメソッドを別途定義されることが理想です。</remarks>
        Task<RelationAccountCollection<T>> GetRelatedAccountsAsync();

        /// <summary>
        /// 更新された関係性を適用します。
        /// </summary>
        /// <returns>関係性が変更されたアカウントの数</returns>
        Task<int> ApplyUpdatedRelationAsync();
    }
}
