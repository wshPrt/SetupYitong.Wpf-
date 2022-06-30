using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 快捷右键-文件详情VM
    /// </summary>
   public class ShortcutsFileDetailsViewModel: BindableBase,IDialogAware
    {
        public ShortcutsFileDetailsViewModel()
        {
                
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
        #endregion
    }
}
