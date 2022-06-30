using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetupYitong.Wpf.Views
{
    /// <summary>
    /// ProjectList.xaml 的交互逻辑
    /// </summary>
    public partial class ProjectList : UserControl
    {
        public ProjectList()
        {
            InitializeComponent();
            ////为界面元素注册区域
            //RegionManager.SetRegionName(ctlProjectDetails, "ProjectDetailsRegion");
            //////为指定区域指定页面
            //regionManager.RegisterViewWithRegion("ProjectDetailsRegion", typeof(ProjectDetails));
        }
    }
}
