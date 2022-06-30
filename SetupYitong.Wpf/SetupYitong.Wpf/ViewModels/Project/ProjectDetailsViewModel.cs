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
    public class ProjectDetailsViewModel : BindableBase, IDialogAware
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public ProjectDetailsViewModel(IRegionManager regionManager,IDialogHostService dialogHost)
        {
            this._regionManager = regionManager;
            this._dialogHost = dialogHost;
            DelWarnCommand = new DelegateCommand(DelProjectWarn);
            ProjectArchiveCommand = new DelegateCommand(ProjectArchive);
            SettingCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProbjectSetting");
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
        public DelegateCommand DelWarnCommand { get; private set; }
        public DelegateCommand ProjectArchiveCommand { get; private set; }
        public DelegateCommand<string> SettingCommand  { get; private set; }
        
        #endregion
        private void DelProjectWarn()
        {
            _dialogHost.ShowDialogAsync("DeleteProjectWarn", null);
        }
        private void ProjectArchive() 
        {
            _dialogHost.ShowDialogAsync("ProjectArchive", null);
        }
    }
}
