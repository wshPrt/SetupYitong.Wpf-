using MaterialDesignThemes.Wpf;
using Prism.Regions;
using System.Windows;

namespace SetupYitong.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            //为界面元素注册区域
            RegionManager.SetRegionName(ctlTop, "TopRegion");
            //为指定区域指定页面
            regionManager.RegisterViewWithRegion("TopRegion", typeof(TopNavigation));
            regionManager.RegisterViewWithRegion("LeftRegion", typeof(LeftNavigation));


            Loaded += (s, e) =>
            {
                var topNavigation = ctlTop.Content as TopNavigation;
                topNavigation.OnMin += (sender, arg) =>
                {
                    //最小化
                    WindowState = WindowState.Minimized;
                };
                topNavigation.OnMax += (sender, arg) =>
                {
                    //最大化和还原
                    if (WindowState != WindowState.Maximized)
                    {
                        WindowState = WindowState.Maximized;
                        topNavigation.btnMAx.ToolTip = "向下还原"; 
                        topNavigation.btnIcon.Kind = (PackIconKind)6608;
                    }
                    else
                    {
                        WindowState = WindowState.Normal;
                        topNavigation.btnIcon.Kind = (PackIconKind)6604;
                        topNavigation.btnMAx.ToolTip = "最大化";
                    }
                };
            };
        }
    }
}
