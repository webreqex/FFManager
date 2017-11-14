using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models
{
    /// <summary>
    /// ServiceAccount, RelationAccount両方に共通するアカウントの概念を定義します。
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// アカウント名を取得します。
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// ID名を取得します。
        /// </summary>
        string Id
        {
            get;
        }

        /// <summary>
        /// 内部IDを取得します。存在しない場合は、nullを表します。
        /// </summary>
        string InternalId
        {
            get;
        }

        /// <summary>
        /// アカウントの実装タイプを判定するための文字列を取得します。
        /// この値は、データのシリアライズ時あるいは、デシリアライズ時に利用します。
        /// </summary>
        string AccountTypeId
        {
            get;
        }
    }
}
