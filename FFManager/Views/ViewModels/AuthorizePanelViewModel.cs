using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

using FFManager.Controller;
using FFManager.Models;
using FFManager.Views.Controls;
using FFManager.Views.ViewModels.AuthorizePanelVMElements;
using FFManager.Views.ViewModels.Bases;

namespace FFManager.Views.ViewModels
{
    /// <summary>
    /// AuthorizePanelのビューモデルを定義します。
    /// </summary>
    public class AuthorizePanelViewModel : SubPanelViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand cancelButtonCommand;
        private EventHandler<CommandEventArgs> cancelButtonClick;
        private DelegateCommand backButtonCommand;
        private DelegateCommand nextButtonCommand;
        private ObservableCollection<_serviceItem> serviceItemList;


        // 公開プロパティ

        /// <summary>
        /// 
        /// </summary>
        public AuthorizePanelState State
        {
            get => this.GetBindingValue<AuthorizePanelState>(nameof(this.State));
            private set => this.SetBindingValue(nameof(this.State), value);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<ServiceItem> ServicesListBoxItems
        {
            get => this.GetBindingValue<ObservableCollection<ServiceItem>>(nameof(this.ServicesListBoxItems));
            private set => this.SetBindingValue(nameof(this.ServicesListBoxItems), value);
        }


        // 公開プロパティ :: コマンド

        /// <summary>
        /// キャンセルボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand CancelButtonCommand
        {
            get => this.cancelButtonCommand;
        }

        /// <summary>
        /// 「戻る」ボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand BackButtonCommand
        {
            get => this.backButtonCommand;
        }

        /// <summary>
        /// 「進む」ボタンがクリックされた際のコマンドを取得します。
        /// </summary>
        public ICommand NextButtonCommand
        {
            get => this.nextButtonCommand;
        }


        // 公開イベント

        /// <summary>
        /// キャンセルボタンがクリックされたときに発生します。
        /// </summary>
        public event EventHandler<CommandEventArgs> CancelButtonClick
        {
            add => this.cancelButtonClick += value;
            remove => this.cancelButtonClick -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい AuthorizePanelViewModel クラスのインスタンスを初期化します。
        /// </summary>
        public AuthorizePanelViewModel()
        {
            // コマンドの初期化
            this.cancelButtonCommand =
                new DelegateCommand(param => this.cancelButtonClick?.Invoke(this, new CommandEventArgs()));
            this.backButtonCommand = new DelegateCommand(param => this.goBack(), param => this.checkCanGoBack());
            this.nextButtonCommand = new DelegateCommand(param => this.goNext(), param => this.checkCanGoNext());

            // サービスリストの初期化
            this.serviceItemList = new ObservableCollection<_serviceItem>();
            this.serviceItemList.CollectionChanged += (sender, e) => this.applyServicesListBoxItems();
        }


        // 非公開メソッド

        /// <summary>
        /// MainControllerのサービス一覧を取得し、サービスリストを更新します。
        /// </summary>
        private void updateServices()
        {
            // メインウィンドウのビューモデルがすべて初期化された後でなければ実行できません。
            var services = this.MainController.ActiveServices;

            this.serviceItemList.Clear();
            foreach (var item in services)
                this.serviceItemList.Add(new _serviceItem(item));
        }

        /// <summary>
        /// サービスリストの内容をUIへ反映します。
        /// </summary>
        private void applyServicesListBoxItems()
        {
            this.ServicesListBoxItems = new ObservableCollection<ServiceItem>(this.serviceItemList.Select(item => item.CreatedItemControl));
        }

        private void goNext()
        {
            this.State++;
        }

        private void goBack()
        {
            this.State--;
        }

        private bool checkCanGoNext()
        {
            return this.State != AuthorizePanelState.ServiceLogin;
        }

        private bool checkCanGoBack()
        {
            return this.State != AuthorizePanelState.ServiceSelect;
        }
        


        // 非公開静的メソッド
        


        // 公開メソッド

        /// <summary>
        /// Serviceを初期化します。
        /// </summary>
        public void ServicesInitialize()
        {
            // サービスアイテムの一覧の初期化
            this.updateServices();
        }


        // 内部メンバ

        /// <summary>
        /// 
        /// </summary>
        public class CommandEventArgs
        {

        }

        /// <summary>
        /// サービスに関する情報を保持します。
        /// </summary>
        private class _serviceItem
        {
            // 非公開フィールド
            private IService service;
            private ServiceItem createdItemControl;


            // 公開プロパティ

            /// <summary>
            /// Serivceに合わせて作成されたListBoxItemコントロールのインスタンスを初期化します。
            /// </summary>
            public ServiceItem CreatedItemControl
            {
                get => this.createdItemControl;
            }


            // コンストラクタ

            /// <summary>
            /// サービスを指定して、新しい _serviceItem クラスのインスタンスを初期化します。
            /// サービスに合わせてListBoxItemも生成されます。CreatedItemControlプロパティで取得可能です。
            /// </summary>
            /// <param name="service"></param>
            public _serviceItem(IService service)
            {
                this.service = service;
                this.createListBoxItem();
            }


            // 非公開メソッド

            private void createListBoxItem()
            {
                var serviceItemElem = new ServiceItem();
                serviceItemElem.ServiceName = this.service.ServiceName;
                serviceItemElem.ServiceUrl = this.service.Url.Host;
                this.createdItemControl = serviceItemElem;
            }
        }
    }
}
