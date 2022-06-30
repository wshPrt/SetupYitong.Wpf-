using Prism.Regions;
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
   /// 权限管理VM
   /// </summary>
   public class PowerManageViewModel: NotifyPropertyBase
    {
        public CommandBase TabChangedCommand { get; set; }
        private readonly IRegionManager _regionManager;
        public PowerManageViewModel(IRegionManager regionManager)
        {
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.EnterpriseManagerPower");
        }
        private UIElement _powerContent;
        public UIElement PowerContent
        {
            get { return _powerContent; }
            set
            {
                Set<UIElement>(ref _powerContent, value);
            }
        }
        private void OnTabChanged(object obj)
        {
            if (obj == null) return;
            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.PowerContent = (UIElement)Activator.CreateInstance(type);
        }
    }
}
