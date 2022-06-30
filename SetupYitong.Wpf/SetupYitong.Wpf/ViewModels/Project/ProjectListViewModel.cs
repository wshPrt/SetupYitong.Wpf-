using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SetupYitong.Wpf.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 项目列表
    /// </summary>
    public class ProjectListViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public ProjectListViewModel(IRegionManager regionManager,IDialogHostService dialogHost)
        {
            this._regionManager = regionManager;
            this._dialogHost = dialogHost;

            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "动画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "原画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card3.png", LeftText = "建模设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card4.png", LeftText = "渲染设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card5.png", LeftText = "场景设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "人物设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "动画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card3.png", LeftText = "原画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card4.png", LeftText = "建模设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card5.png", LeftText = "渲染设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "场景设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "人物设计", RightText = "222" });

            ProjectRelatedCommand = new DelegateCommand<string>(arg =>
           {
               regionManager.Regions["MainRegion"].RequestNavigate("ProjectRelated");
           });
            ProjectDetailsCommand = new DelegateCommand(ProjectDetails);
            OpenProjectWarnCommand = new DelegateCommand(DelProjectWarn);
            ProjectArchiveCommand = new DelegateCommand(ProjectArchive);
            ClickImageCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProbjectAnimationDesign");
            });
            NewGroupCommand = new DelegateCommand(AddNewGroup);
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
        /// 相关信息
        /// </summary>
        public DelegateCommand<string> ProjectRelatedCommand { get; private set; }
        /// <summary>
        /// 项目详情
        /// </summary>
        public DelegateCommand ProjectDetailsCommand { get; private set; }
        /// <summary>
        /// 点击图片
        /// </summary>
        public DelegateCommand<string> ClickImageCommand { get; private set; }
        /// <summary>
        /// 新建分组
        /// </summary>
        public DelegateCommand NewGroupCommand { get; private set; }
        
        #endregion
        private void ProjectDetails() 
        {
            _dialogHost.ShowDialogAsync("ProjectDetails", null);
        }
        /// <summary>
        /// 删除提示框
        /// </summary>
        public DelegateCommand OpenProjectWarnCommand { get; private set; }
        private void DelProjectWarn()
        {
            _dialogHost.ShowDialogAsync("DeleteProjectWarn", null);
        }
        public DelegateCommand ProjectArchiveCommand { get; private set; }
        private void ProjectArchive()
        {
            _dialogHost.ShowDialogAsync("ProjectArchive", null);
        }
        private void AddNewGroup() 
        {
            _dialogHost.ShowDialogAsync("NewGroup", null);
        }
    }
}
