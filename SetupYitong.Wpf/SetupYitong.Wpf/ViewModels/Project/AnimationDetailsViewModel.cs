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
    /// 项目-动画设计-详情VM
    /// </summary>
   public class AnimationDetailsViewModel: BindableBase, IDialogAware
    {
        private readonly IDialogHostService _dialogHost;
        public AnimationDetailsViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
           
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
