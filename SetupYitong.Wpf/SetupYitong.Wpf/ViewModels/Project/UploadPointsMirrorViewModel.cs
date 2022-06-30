using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using SetupYitong.Wpf.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 上传分镜脚本VM
    /// </summary>
   public class UploadPointsMirrorViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public UploadPointsMirrorViewModel(IRegionManager regionManager, IDialogHostService dialogHost)
        {
            this._regionManager = regionManager;
            this._dialogHost = dialogHost;

            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "通用模版", RightText = "222" });
             
             GoBackCommand = new DelegateCommand<string>(arg =>
                {
                    regionManager.Regions["MainRegion"].RequestNavigate("ProjectRelatedInfo");
                });
            ConfirmCommand = new DelegateCommand(OpenConfirmTips);
        }
        #region 属性
        public class CardModel
        {
            public string ImageURI { get; set; } = "";
            public string LeftText { get; set; } = "";
            public string RightText { get; set; } = "";
        }
        public List<CardModel> CardList { get; set; } = new List<CardModel>();
        /// <summary>
        /// 返回
        /// </summary>
        public DelegateCommand<string> GoBackCommand { get; private set; }
        /// <summary>
        /// 确认
        /// </summary>
        public DelegateCommand ConfirmCommand { get; private set;}
        #endregion

        private void OpenConfirmTips() 
        {
            _dialogHost.ShowDialogAsync("ConfirmTips", null);
        }
    }
}
