using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using FFManager.Views.ViewModels.Bases;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// MainWindowのビューモデルを定義します。
    /// </summary>
    public class MainWindowViewModel : InternalViewModelBase
    {
        // 非公開フィールド
        private string applicationName;
        private DelegateCommand closeCommand;


        // 公開プロパティ
        
        /// <summary>
        /// 現在の状態をウィンドウタイトルとして表示する際、文字列を取得または設定します。
        /// </summary>
        public string CurrentStateTextForTitle
        {
            get => this.GetValue<string>(nameof(this.CurrentStateTextForTitle));
            set => this.SetValue(nameof(this.CurrentStateTextForTitle), value);
        }

        /// <summary>
        /// 現在のウィンドウタイトルを取得します。
        /// </summary>
        public string WindowTitle
        {
            get => this.GetValue<string>(nameof(this.WindowTitle));
            private set => this.SetValue(nameof(this.WindowTitle), value);
        }

        /// <summary>
        /// ウィンドウを閉じるかどうかを示すフラグ値を取得または設定します。
        /// </summary>
        public bool CloseWindowFlag
        {
            get => this.GetValue<bool>(nameof(this.CloseWindowFlag));
            set => this.SetValue(nameof(this.CloseWindowFlag), value);
        }

        /// <summary>
        /// 閉じる操作を行う際のCommandを取得します。
        /// </summary>
        public ICommand CloseCommand
        {
            get => this.closeCommand;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい MainWindowViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public MainWindowViewModel()
        {
            this.applicationName = (string)System.Windows.Application.Current.FindResource("ApplicationName");
            this.CloseWindowFlag = false;

            this.closeCommand = new DelegateCommand(param => this.CloseWindowFlag = true);

            this.PropertyChanged += MainWindowViewModel_PropertyChanged;
            this.CurrentStateTextForTitle = null;
        }

        
        // 非公開メソッド


        // 非公開メソッド :: イベント

        private void MainWindowViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(this.CurrentStateTextForTitle):
                    var newTitle = this.applicationName;
                    if (this.CurrentStateTextForTitle != null && this.CurrentStateTextForTitle != "")
                        newTitle = this.applicationName + " - " + this.CurrentStateTextForTitle;
                    this.WindowTitle = newTitle;
                    break;
            }
        }
    }
}
