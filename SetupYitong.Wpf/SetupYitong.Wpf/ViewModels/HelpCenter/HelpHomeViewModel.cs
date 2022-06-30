using Prism.Commands;
using Prism.Mvvm;
using SetupYitong.Commons.Base;
using SetupYitong.Wpf.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 帮助中心VM
    /// </summary>
    public class HelpHomeViewModel: NotifyPropertyBase
    {
        private readonly IDialogHostService _dialogHost;
        public HelpHomeViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.Personal");
            HelpCourseCommand = new DelegateCommand(OpenHelpCourse);
        }
        #region 属性
        private UIElement _helpContent;
        public UIElement HelpContent
        {
            get { return _helpContent; }
            set
            {
                Set<UIElement>(ref _helpContent, value);
            }
        }
        public CommandBase TabChangedCommand { get; set; }
        /// <summary>
        /// 打开帮助教程
        /// </summary>
        public DelegateCommand HelpCourseCommand { get; private set; }
        #endregion

        private void OnTabChanged(object obj)
        {
            if (obj == null) return;
            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.HelpContent = (UIElement)Activator.CreateInstance(type);
        }

        /// <summary>
        /// 弹出帮助教程
        /// </summary>
        private void OpenHelpCourse()
        {
            _dialogHost.ShowDialogAsync("HelpCourse", null);
        }
    }
}
