using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using FFManager.Controller;
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
        private DelegateCommand switchWindowStateCommand;
        private DelegateCommand minimizeCommand;

        private MainController controller;


        // 公開プロパティ :: バインディングプロパティ
        
        /// <summary>
        /// 現在の状態をウィンドウタイトルとして表示する際、文字列を取得または設定します。
        /// </summary>
        public string CurrentStateTextForTitle
        {
            get => this.GetBindingValue<string>(nameof(this.CurrentStateTextForTitle));
            set => this.SetBindingValue(nameof(this.CurrentStateTextForTitle), value);
        }

        /// <summary>
        /// 現在の状態をステータスバーの文字列として表示する場合の値を取得または設定します。
        /// </summary>
        public string CurrentStateTextForStatusBar
        {
            get => this.GetBindingValue<string>(nameof(this.CurrentStateTextForStatusBar));
            set => this.SetBindingValue(nameof(this.CurrentStateTextForStatusBar), value);
        }

        /// <summary>
        /// 現在のウィンドウタイトルを取得します。
        /// </summary>
        public string WindowTitle
        {
            get => this.GetBindingValue<string>(nameof(this.WindowTitle));
            private set => this.SetBindingValue(nameof(this.WindowTitle), value);
        }

        /// <summary>
        /// ウィンドウを閉じるかどうかを示すフラグ値を取得または設定します。
        /// </summary>
        public bool CloseWindowFlag
        {
            get => this.GetBindingValue<bool>(nameof(this.CloseWindowFlag));
            set => this.SetBindingValue(nameof(this.CloseWindowFlag), value);
        }

        /// <summary>
        /// ウィンドウの状態を表す WindowState を取得または設定します。
        /// </summary>
        public WindowState WindowState
        {
            get => this.GetBindingValue<WindowState>(nameof(this.WindowState));
            set => this.SetBindingValue(nameof(this.WindowState), value);
        }

        /// <summary>
        /// ログインパネルを表示するかどうかを示す値を取得または設定します。
        /// </summary>
        public bool LoginPanelIsShow
        {
            get => this.GetBindingValue<bool>(nameof(this.LoginPanelIsShow));
            set => this.SetBindingValue(nameof(this.LoginPanelIsShow), value);
        }


        // 公開プロパティ :: コマンド

        /// <summary>
        /// 閉じる操作を行う際のCommandを取得します。
        /// </summary>
        public ICommand CloseCommand
        {
            get => this.closeCommand;
        }

        /// <summary>
        /// ウィンドウの状態を切り替える際のCommandを取得します。
        /// </summary>
        public ICommand SwitchWindowStateCommand
        {
            get => this.switchWindowStateCommand;
        }

        /// <summary>
        /// ウィンドウを最小化する際のCommandを取得します。
        /// </summary>
        public ICommand MinimizeCommand
        {
            get => this.minimizeCommand;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい MainWindowViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public MainWindowViewModel()
        {
            this.applicationName = (string)Application.Current.FindResource("ApplicationName");
            this.CloseWindowFlag = false;
            this.WindowState = WindowState.Normal;

            this.closeCommand = new DelegateCommand(this.closeCommandProc);
            this.switchWindowStateCommand = new DelegateCommand(this.switchWindowStateCommandProc);
            this.minimizeCommand = new DelegateCommand(this.minimizeCommandProc);

            this.PropertyChanged += MainWindowViewModel_PropertyChanged;
            this.CurrentStateTextForTitle = null;
            this.CurrentStateTextForStatusBar = "準備完了";
            this.LoginPanelIsShow = true;

            this.controller = new MainController(new ControllerInitializeParameter()
            {
                Services = new Models.IService[]
                {
                    new Models.Services.Tests.ModelTestService("test1")
                },
            });
        }

        
        // 非公開メソッド

        private void closeCommandProc(Object param)
        {
            this.CloseWindowFlag = true;
        }

        private void switchWindowStateCommandProc(Object param)
        {
            if (this.WindowState == WindowState.Normal || this.WindowState == WindowState.Minimized)
                this.WindowState = WindowState.Maximized;
            else if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }

        private void minimizeCommandProc(Object param)
        {
            this.WindowState = WindowState.Minimized;
        }
        

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
