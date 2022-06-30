using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SetupYitong.Wpf.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
    public class ProjectRelatedInfoViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public ProjectRelatedInfoViewModel(IRegionManager regionManager ,IDialogHostService dialogHost)
        {
            this._regionManager = regionManager;
            this._dialogHost = dialogHost;
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "通用模版", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "三维模版", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card3.png", LeftText = "二维模版", RightText = "222" });

            GoBackProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Project");
            });
            OpenTemplateCommand = new DelegateCommand(OpenTemplate);
            OpenTemplateDetailsCommand = new DelegateCommand(OpenTemplateDetails);
            UploadScriptCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("UploadPointsMirror");
            });
            ClickImageCommand = new DelegateCommand(ClickImage);
            SelectionCommand = new DelegateCommand(Selection);
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
        /// 下一步,上传脚本按钮，切换显示
        /// </summary>
        private Visibility _visibilityScript = Visibility.Hidden;
        public Visibility VisibilityScript
        {
            get { return _visibilityScript; }
            set { _visibilityScript = value; RaisePropertyChanged();}
        }

        /// <summary>
        /// 确认创建
        /// </summary>
        public DelegateCommand<string> ConfirmCreateCommand { get; private set; }
        /// <summary>
        /// 返回项目列表
        /// </summary>
        public DelegateCommand<string> GoBackProjectCommand { get; private set;}
        /// <summary>
        /// 打开模版
        /// </summary>
        public DelegateCommand OpenTemplateCommand { get; private set; }
        /// <summary>
        /// 打开模版详情
        /// </summary>
        public DelegateCommand OpenTemplateDetailsCommand { get; private set; }
        /// <summary>
        /// 打开上传分镜
        /// </summary>
        public DelegateCommand<string> UploadScriptCommand{ get; private set;}
        /// <summary>
        /// 点击三维动画
        /// </summary>
        public DelegateCommand ClickImageCommand { get; private set;}
        /// <summary>
        /// 选择人员
        /// </summary>
        public DelegateCommand SelectionCommand { get; private set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        private void OpenTemplate() 
        {
            _dialogHost.ShowDialogAsync("SelectTemplate", null);
        }
        private void OpenTemplateDetails() 
        {
            _dialogHost.ShowDialogAsync("TemplateDetails", null);
        }
        private void ClickImage() 
        {
            if (VisibilityScript== Visibility.Hidden)
            {
                VisibilityScript = Visibility.Visible;
            }
            else 
            {
                VisibilityScript = Visibility.Hidden;
            }
            
        }
        private void Selection() 
        {
            _dialogHost.ShowDialogAsync("SelectMembers", null);
        }
    }
}
