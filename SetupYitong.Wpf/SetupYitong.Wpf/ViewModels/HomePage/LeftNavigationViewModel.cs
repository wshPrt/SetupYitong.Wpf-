using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    public class LeftNavigationViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        public LeftNavigationViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            ProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Project");
            });
            FilesCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("FileHome");
            });
            TeamCommand = new DelegateCommand<string>(arg =>
            {
               // regionManager.Regions["MainRegion"].RequestNavigate("FileList");
               // regionManager.Regions["MainRegion"].RequestNavigate("FileDetails");
                regionManager.Regions["MainRegion"].RequestNavigate("Team");
            });
            SettingCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Setup");
            }); 
           HelpCommand = new DelegateCommand<string>(arg =>
           {
               regionManager.Regions["MainRegion"].RequestNavigate("HelpHome");
           });
        }
        #region 属性
        /// <summary>
        /// 项目指令
        /// </summary>
        public DelegateCommand<string> ProjectCommand { get; private set; }
        /// <summary>
        /// 文件指令
        /// </summary>
        public DelegateCommand<string> FilesCommand { get; private set; }
        /// <summary>
        /// 团队指令
        /// </summary>
        public DelegateCommand<string> TeamCommand { get; private set; }
        /// <summary>
        /// 回收站指令
        /// </summary>
        public DelegateCommand<string> RecycleCommand { get; private set; }
        /// <summary>
        /// 帮助指令
        /// </summary>
        public DelegateCommand<string> HelpCommand { get; private set; }
        /// <summary>
        /// 设置指令
        /// </summary>
        public DelegateCommand<string> SettingCommand { get; private set; }
        #endregion
    }
}
