using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FFManager.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    public class RelationAccountCollection<TService>
        : ObservableCollection<IRelationAccount<TService>> where TService : IService
    {
    }
}
