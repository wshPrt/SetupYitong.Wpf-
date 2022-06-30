using MaterialDesignThemes.Wpf;
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
    /// TopNavigation.xaml 的交互逻辑
    /// </summary>
    public partial class TopNavigation : UserControl
    {
        public TopNavigation()
        {
            InitializeComponent();
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            OnMax?.Invoke(this, e);
        }

        public event Action<object, RoutedEventArgs> OnMin;
        public event Action<object, RoutedEventArgs> OnMax;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            OnMin?.Invoke(this, e);
        }
    }
}
