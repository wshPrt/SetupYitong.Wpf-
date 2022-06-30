using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 注册提醒VM
    /// </summary>
   public class RegisterResultViewModel: BindableBase
    {
        public RegisterResultViewModel()
        {
            CloseCommand = new DelegateCommand(CloseRegister);
        }

        #region 属性
        /// <summary>
        /// 关闭
        /// </summary>
        public DelegateCommand CloseCommand { get; private set; }
        private bool toClose = false;
        /// <summary>
        /// 是否要关闭窗口
        /// </summary>
        public bool ToClose
        {
            get
            {
                return toClose;
            }
            set
            {
                if (toClose != value)
                {
                    toClose = value;
                    this.RaisePropertyChanged("ToClose");
                }
            }
        }
        #endregion

        private void CloseRegister() 
        {
            ToClose = true;
        }
    }
}
