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
    /// 帮助教程VM
    /// </summary>
   public class HelpCourseViewModel: BindableBase, IDialogAware
    {
        public HelpCourseViewModel()
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
