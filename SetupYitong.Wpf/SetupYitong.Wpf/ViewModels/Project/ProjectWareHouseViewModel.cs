using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 项目仓库
    /// </summary>
    public class ProjectWareHouseViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        public ProjectWareHouseViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            BacktTrackProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Project");
            });
        }
        /// <summary>
        /// 项目指令
        /// </summary>
        public DelegateCommand<string> BacktTrackProjectCommand { get; private set; }
    }
}
