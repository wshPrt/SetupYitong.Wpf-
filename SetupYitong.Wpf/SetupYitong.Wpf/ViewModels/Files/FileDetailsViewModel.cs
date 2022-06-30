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
    /// 文件详情VM
    /// </summary>
   public class FileDetailsViewModel:BindableBase, IDialogAware
    {
        private readonly IDialogHostService _dialogHost;
        public FileDetailsViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            DelFileCommand = new DelegateCommand(DelFileDialog);
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
        /// 删除提示
        /// </summary>
        public DelegateCommand DelFileCommand { get; private set; }
        #endregion

        /// <summary>
        /// 弹窗删除提示框
        /// </summary>
        private void DelFileDialog() 
        {
            _dialogHost.ShowDialogAsync("DeleteFile", null);
        }
    }
}
