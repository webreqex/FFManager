using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocusCommon.Windows.ViewModels;

using FFManager.Models.Bases;
using FFManager.Models.Elements;

namespace FFManager.Models.Services.Tests
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelTestService : ServiceBase
    {
        // 非公開フィールド
        private string clientId;

        // コンストラクタ

        /// <summary>
        /// 新しい ModelTestService クラスのインスタンスを初期化します．
        /// </summary>
        /// <param name="clientId"></param>
        public ModelTestService(string clientId)
            : base("ModelTestService", new Uri("http://test.a32kita.tk/"))
        {
            this.clientId = clientId;
        }


        // 限定公開メソッド

        protected override AuthorizeContext OnGetAuthorizeContext(AuthorizeParameter parameter)
        {
            var viewContext = new ViewContext();
            viewContext.MaxStage = 1;
            viewContext.AuthorizeChild = new AuthorizeChild();

            var context = new AuthorizeContext(parameter, viewContext);
            return context;
        }


        // 公開メソッド

        private class AuthorizeChild : ChildControlViewModelBase
        {
            // 非公開フィールド

            // 公開プロパティ

            // コンストラクタ

            public AuthorizeChild()
            {
                this.Target = new Views.Controls.ServiceAuthorization.TestService.ServiceLoginPanel();
            }
        }
    }
}
