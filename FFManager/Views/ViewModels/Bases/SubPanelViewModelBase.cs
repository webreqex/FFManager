using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocusCommon.Windows.ViewModels;

using FFManager.Controller;

namespace FFManager.Views.ViewModels.Bases
{
    /// <summary>
    /// ExtendedViewModelBase を内部向けに拡張します。
    /// </summary>
    public class SubPanelViewModelBase : ExtendedViewModelBase
    {
        // 非公開フィールド
        private MainController mainController;


        // 公開プロパティ

        /// <summary>
        /// 親ウィンドウにあたるMainWindowのビューモデルが存在している場合は、取得または設定します。
        /// </summary>
        public MainWindowViewModel ParentWindowViewModel
        {
            get => this.GetBindingValue<MainWindowViewModel>(nameof(this.ParentWindowViewModel));
            set => this.SetBindingValue(nameof(this.ParentWindowViewModel), value);
        }


        // 限定公開プロパティ

        protected MainController MainController
        {
            get => this.getMainController();
        }


        // コンストラクタ

        /// <summary>
        /// 新しい SubPanelViewModelBase クラスのインスタンスを初期化します。
        /// </summary>
        public SubPanelViewModelBase()
        {
            this.mainController = null;
        }


        // 非公開メソッド

        private MainController getMainController()
        {
            if (this.mainController == null)
            {
                var mainwndVM = this.ParentWindowViewModel;
                var controller = (MainController)mainwndVM.GetType().GetField("controller", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(mainwndVM);
                this.mainController = controller ?? throw new Exception("MainControllerの取得に失敗しました。");
            }
            
            return this.mainController;
        }
    }
}
