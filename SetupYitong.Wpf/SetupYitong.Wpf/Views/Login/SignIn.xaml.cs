using SetupYitong.Commons.IniFile;
using SetupYitong.Commons.MD5Poxy;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using static SetupYitong.Commons.Untils.Configuration;

namespace SetupYitong.Wpf.Views
{
    /// <summary>
    /// SignIn.xaml 的交互逻辑
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
            string cfgINI = AppDomain.CurrentDomain.BaseDirectory + SerivceFiguration.INI_CFG;
            if (File.Exists(cfgINI))
            {
                IniFiles ini = new IniFiles(cfgINI);
                txtUser.Text = ini.IniReadValue("Login", "User");
                txtPassWord.Password = CEncoder.Decode(ini.IniReadValue("Login", "Password"));
                chk.IsChecked = ini.IniReadValue("Login", "SaveInfo") == "Y";

            }
        }
    }
}
