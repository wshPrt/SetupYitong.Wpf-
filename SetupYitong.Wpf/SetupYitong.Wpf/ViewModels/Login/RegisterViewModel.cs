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
    /// 新用户注册VM
    /// </summary>
    public class RegisterViewModel: BindableBase
    {
        public RegisterViewModel()
        {
            CloseCommand = new DelegateCommand(CloseRegister);
        }
        /// <summary>
        /// 关闭
        /// </summary>
        public DelegateCommand CloseCommand { get; private set; }

        /// <summary>
        /// 关闭登陆
        /// </summary>
        private void CloseRegister()
        {
            Environment.Exit(0);
        }
    }
}
