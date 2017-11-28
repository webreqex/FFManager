using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models.Elements
{
    public class AuthorizeContext
    {
        // 非公開フィールド
        private AuthorizeParameter authorizeParameter;
        private ViewContext viewContext;


        // 公開プロパティ
        
        /// <summary>
        /// 
        /// </summary>
        public ViewContext ViewContext
        {
            get => this.viewContext;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい AuthorizeContext クラスのインスタンスを初期化します。
        /// </summary>
        /// <param name="parameter">処理のパラメーター</param>
        /// <param name="viewContext">認証に使用する ViewContext</param>
        public AuthorizeContext(AuthorizeParameter parameter, ViewContext viewContext)
        {
            this.authorizeParameter = parameter;
            this.viewContext = viewContext;
        }
    }
}
