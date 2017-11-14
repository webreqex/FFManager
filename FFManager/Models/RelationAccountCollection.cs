using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FFManager.Models
{
    /// <summary>
    /// 現在のアカウントとフォロー／フォロワー／プロテクト関係にある他者のアカウントのコレクションを表します。
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    public class RelationAccountCollection<TService>
        : ObservableCollection<IRelationAccount<TService>> where TService : IService
    {
    }
}
