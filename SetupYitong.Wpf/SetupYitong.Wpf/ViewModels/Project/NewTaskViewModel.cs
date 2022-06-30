using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
   /// <summary>
   /// 项目-动画设计-角色动画-新建任务VM
   /// </summary>
   public class NewTaskViewModel : BindableBase, IDialogAware
    {
        private readonly IRegionManager _regionManager;
        public NewTaskViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            GoBackProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Project");
            });
            GoBackAnimationCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProbjectAnimationDesign");
            });
        }
        #region 属性
        public string Title { get; set; }
        public event Action<IDialogResult> RequestClose;
        public bool CanCloseDialog()
        {
            return true;
        }
        public void OnDialogClosed()
        {
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
        public DelegateCommand<string> GoBackProjectCommand { get; private set; }
        /// <summary>
        /// 返回动画
        /// </summary>
        public DelegateCommand<string> GoBackAnimationCommand { get; private set; }
        
        #endregion
    }
}
