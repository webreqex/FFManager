using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using LocusCommon.Windows.ViewModels;

namespace FFManager.Models
{
    /// <summary>
    /// 各サービスのログイン認証用のビューのビューモデルの共通基底クラスを定義します。
    /// </summary>
    public class AuthorizeViewModelBase : ExtendedViewModelBase
    {
        // 非公開フィールド


        // 公開プロパティ

        /// <summary>
        /// このビューモデルで管理しているターゲットコントロールを設定します。
        /// </summary>
        public Control Target
        {
            get => this.GetBindingValue<Control>(nameof(this.Target));
            set => this.SetBindingValue(nameof(this.Target), value);
        }
    }
}
