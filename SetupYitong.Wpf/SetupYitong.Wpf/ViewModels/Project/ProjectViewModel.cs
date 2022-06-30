using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SetupYitong.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 项目
    /// </summary>
    public class ProjectViewModel: NotifyPropertyBase
    {
        private UIElement _projectContent;

        public UIElement ProjectContent
        {
            get { return _projectContent; }
            set
            {
                Set<UIElement>(ref _projectContent, value);
            }
        }
        public CommandBase TabChangedCommand { get; set; }

        private readonly IRegionManager _regionManager;
        public ProjectViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.ProjectList");

            ProjectWareHouseCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProjectWareHouse");
            });
            AddProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("ProjectRelatedInfo");
            });
        }

        private void OnTabChanged(object obj)
        {
            if (obj == null) return;
            // 完整方式
            //string[] strValues = obj.ToString().Split('|');
            //Assembly assembly = Assembly.LoadFrom(strValues[0]);
            //Type type = assembly.GetType(strValues[1]);
            //this.ProjectContent = (UIElement)Activator.CreateInstance(type);

            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.ProjectContent = (UIElement)Activator.CreateInstance(type);
        }

        #region 
        /// <summary>
        /// 项目仓库
        /// </summary>
        public DelegateCommand<string> ProjectWareHouseCommand { get; private set; }
        /// <summary>
        /// 新建项目
        /// </summary>
        public DelegateCommand<string> AddProjectCommand { get; private set; }
        #endregion
    }
}
