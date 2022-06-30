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
    /// 上传/同步文件VM
    /// </summary>
   public class UploadFilesViewModel: NotifyPropertyBase
    {
        private UIElement _fileProgressContent;

        public UIElement FileProgressContent
        {
            get { return _fileProgressContent; }
            set
            {
                Set<UIElement>(ref _fileProgressContent, value);
            }
        }
        public CommandBase TabChangedCommand { get; set; }

        private readonly IRegionManager _regionManager;
        public UploadFilesViewModel(IRegionManager regionManager)
        {

            this._regionManager = regionManager;
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.Upload");
        }
        private void OnTabChanged(object obj)
        {
            if (obj == null) return;

            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.FileProgressContent = (UIElement)Activator.CreateInstance(type);
        }
    }
}
