using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models
{
    /// <summary>
    /// 現在のアカウントとの関係性を表すFlagsな値を定義します。
    /// </summary>
    [Flags]
    public enum RelationType
    {
        /// <summary>
        /// 現在のアカウントとは関係を持ちません。
        /// </summary>
        Unrelated = 0,

        /// <summary>
        /// 現在のアカウントをフォローしています。
        /// </summary>
        Follower = 1,

        /// <summary>
        /// 現在のアカウントからフォローしています。
        /// </summary>
        Following = 2,

        /// <summary>
        /// プロテクトしています。
        /// </summary>
        Protected = 4,
    }
}
