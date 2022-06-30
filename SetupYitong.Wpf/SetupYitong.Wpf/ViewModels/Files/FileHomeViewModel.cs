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
    /// 文件主页Vm
    /// </summary>
    public class FileHomeViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public FileHomeViewModel(IRegionManager regionManager, IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            this._regionManager = regionManager;

            CardList.Add(new CardModel { ImageURI = "/Resource/Image/file.png", LeftText = "参考资料", TitleURI = "/Resource/Image/check.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/file.png", LeftText = "成果文件", TitleURI = "/Resource/Image/check.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/word.png", LeftText = "需求文档.doc", TitleURI = "/Resource/Image/check.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/word.png", LeftText = "需求文档2.doc", TitleURI = "/Resource/Image/lock.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/word.png", LeftText = "需求文档3.doc", TitleURI = "/Resource/Image/sync.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/excel.png", LeftText = "需求列表.xls", TitleURI = "/Resource/Image/check.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/u185.png", LeftText = "1jpg", TitleURI = "/Resource/Image/lock.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/u191.png", LeftText = "222.jpg", TitleURI = "/Resource/Image/lock.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/u191.png", LeftText = "33.jpg", TitleURI = "/Resource/Image/sync.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/u185.png", LeftText = "227.jpg", TitleURI = "/Resource/Image/sync.png" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/u185.png", LeftText = "33429.jpg", TitleURI = "/Resource/Image/lock.png" });

            TaskFeedbackCommand = new DelegateCommand(TaskFeedback);

            ReturnTaskCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProbjectAnimationDesign");
            });
            VersionHistoryCommand = new DelegateCommand(VersionHistory);
            FileDetailsCommand = new DelegateCommand(FileDetails);
            DelFileCommand = new DelegateCommand(DelFile);
        }

        #region 属性
        public class CardModel
        {
            public string ImageURI { get; set; } = "";
            public string LeftText { get; set; } = "";
            public string TitleURI { get; set; } = "";
        }
        public List<CardModel> CardList { get; set; } = new List<CardModel>();

        /// <summary>
        /// 任务反馈
        /// </summary>
        public DelegateCommand TaskFeedbackCommand { get; private set; }
        /// <summary>
        /// 点击图片
        /// </summary>
        public DelegateCommand ClickImageCommand { get; private set; }
        /// <summary>
        /// 返回项目任务列表
        /// </summary>
        public DelegateCommand<string> ReturnTaskCommand { get; private set; }
        /// <summary>
        /// 版本历史
        /// </summary>
        public DelegateCommand VersionHistoryCommand { get; private set; }
        /// <summary>
        /// 文件详情
        /// </summary>
        public DelegateCommand FileDetailsCommand { get; private set; }
        /// <summary>
        /// 删除文件
        /// </summary>
        public DelegateCommand DelFileCommand { get; private set; }
        
        #endregion

        /// <summary>
        /// 任务反馈
        /// </summary>
        private void TaskFeedback()
        {
            _dialogHost.ShowDialogAsync("TaskFeedBack", null);
        }
        private void VersionHistory() 
        {
            _dialogHost.ShowDialogAsync("VersionHistory", null);
        }
        private void FileDetails() 
        {
            //_dialogHost.ShowDialogAsync("FileDetails", null);
            _dialogHost.ShowDialogAsync("ShortcutsFileDetails", null);
        }
        private void DelFile() 
        {
            _dialogHost.ShowDialogAsync("DeleteFile", null);
        }
    }
}
