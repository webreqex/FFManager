using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocusCommon.Windows.ViewModels;

namespace FFManager.Models.Elements
{
    /// <summary>
    /// 
    /// </summary>
    public class ViewContext
    {
        // 非公開フィールド
        private IChildControlViewModel authorizeChild;
        private int currentStage;
        private int maxStage;
        private EventHandler currentStageChanged;
        

        // 公開フィールド

        /// <summary>
        /// ビューに使用するコントロールのビューモデルを取得または設定します。
        /// このビューモデルは、IChildControlViewModelを実装している必要があります。
        /// </summary>
        public IChildControlViewModel AuthorizeChild
        {
            get => this.authorizeChild;
            set => this.authorizeChild = value;
        }

        /// <summary>
        /// 現在の認証の進捗状況を取得または設定します。
        /// 値は0からMaxStageの間のみ使用できます。
        /// </summary>
        public int CurrentStage
        {
            get => this.getCurrentStage();
            set => this.setCurrentStage(value);
        }

        /// <summary>
        /// 認証の段階数を取得または設定します。
        /// </summary>
        public int MaxStage
        {
            get => this.maxStage;
            set => this.maxStage = value;
        }


        // 公開イベント

        /// <summary>
        /// CurrentStage が変化した時に発生します。
        /// </summary>
        public event EventHandler CurrentStageChanged
        {
            add => this.currentStageChanged += value;
            remove => this.currentStageChanged -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい ViewContext クラスのインスタンスを初期化します。
        /// </summary>
        public ViewContext()
        {
            this.authorizeChild = null;
            this.currentStage = 0;
            this.maxStage = 0;
            this.currentStageChanged = null;
        }


        // 非公開メソッド

        private int getCurrentStage()
        {
            return this.currentStage;
        }

        private void setCurrentStage(int value)
        {
            if (value < 0 || value > this.maxStage)
                throw new ArgumentOutOfRangeException();

            this.currentStage = value;
            this.currentStageChanged?.Invoke(this, new EventArgs());
        }
    }
}
