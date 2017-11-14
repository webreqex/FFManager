using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFManager.Models
{
    /// <summary>
    /// IServiceAccountとフォロー／フォロワー関係を持つ T (IService) のアカウントを表します。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRelationAccount<T> : IAccount where T : IService
    {
        /// <summary>
        /// この関連アカウントの関連先となるIServiceAccountを取得します。
        /// </summary>
        IServiceAccount<T> RelatedOwner
        {
            get;
        }
    }
}
