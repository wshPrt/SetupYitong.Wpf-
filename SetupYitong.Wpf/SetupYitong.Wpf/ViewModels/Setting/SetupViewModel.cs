using SetupYitong.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 设置VM
    /// </summary>
   public class SetupViewModel: NotifyPropertyBase
    {
        public SetupViewModel()
        {
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.EnterpriseSetup");
        }

        #region 属性
        private UIElement _setupContent;
        public UIElement SetupContent
        {
            get { return _setupContent; }
            set
            {
                Set<UIElement>(ref _setupContent, value);
            }
        }
        public CommandBase TabChangedCommand { get; set; }
        #endregion

        private void OnTabChanged(object obj)
        {
            if (obj == null) return;
            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.SetupContent = (UIElement)Activator.CreateInstance(type);
        }
    }
}
