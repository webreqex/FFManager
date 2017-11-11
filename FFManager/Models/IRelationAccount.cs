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
    public interface IRelationAccount<T> where T : IService
    {
    }
}
