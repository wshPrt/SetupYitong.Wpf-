using Prism.Commands;
using Prism.Mvvm;
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
    //任务详情VM
    /// </summary>

    public class TaskDetailsViewModel : BindableBase, IDialogAware
    {
        private readonly IDialogHostService _dialogHost;
        public TaskDetailsViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            DelTaskCommand = new DelegateCommand(DelTask);
            ProgressCommand = new DelegateCommand(SettingProgress);
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
        /// <summary>
        /// 删除任务
        /// </summary>
        public DelegateCommand DelTaskCommand { get; private set;}
        /// <summary>
        /// 进度设置
        /// </summary>
        public DelegateCommand ProgressCommand { get; private set; }
        #endregion

        /// <summary>
        /// 删除任务
        /// </summary>
        private void DelTask() 
        {
            _dialogHost.ShowDialogAsync("DeleteProjectWarn", null);
        }
        /// <summary>
        /// 设置进度
        /// </summary>
        private void SettingProgress() 
        {
            _dialogHost.ShowDialogAsync("SettingTaskStatus", null);
        }
    }
}
