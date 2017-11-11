using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFManager.Models
{
    /// <summary>
    /// アプリケーションで管理する T (IService) のアカウントを表します。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IServiceAccount<T> where T : IService
    {
    }
}
