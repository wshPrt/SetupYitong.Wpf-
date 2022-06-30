using Prism.Commands;
using Prism.Mvvm;
using SetupYitong.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
   public  class TopNavigationViewModel:BindableBase
    {
        public TopNavigationViewModel()
        {
            CloseCommand = new DelegateCommand(Close);
        }
        #region 属性
        public MainWindow _mainWindow { get; set; } = null;

        /// <summary>
        /// 关闭指令
        /// </summary>
        //public DelegateCommand CloseCommand { get; private set; }
        //public DelegateCommand MaxCommand { get; private set; }
        public DelegateCommand CloseCommand { get; private set; }
        #endregion

        /// <summary>
        /// 关闭主程序
        /// </summary>
        private void Close() 
        {
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }
    }
}
