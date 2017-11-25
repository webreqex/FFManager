using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FFManager.Models.Elements
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthorizeParameter
    {
        // 非公開フィールド
        private Control authorizeParentPanel;


        // 公開プロパティ

        /// <summary>
        /// 認証画面のコントロールを取得します．
        /// </summary>
        public Control AuthorizeParentPanel
        {
            get => this.authorizeParentPanel;
            set => this.authorizeParentPanel = value;
        }
    }
}
