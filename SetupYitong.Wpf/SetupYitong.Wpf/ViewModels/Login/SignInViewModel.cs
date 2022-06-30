using Prism.Commands;
using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using SetupYitong.Commons.IniFile;
using SetupYitong.Commons.MD5Poxy;
using SetupYitong.Wpf.Model.SignIn;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SetupYitong.Commons.Untils.Configuration;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 登陆
    /// </summary>
   public class SignInViewModel: BindableBase
    {
        public SignInViewModel(IContainerExtension Container, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            LoginInfo = new LoginModel();
            CloseCommand = new DelegateCommand(CloseSignIn);
            LogInCommand = new DelegateCommand(SignIn);
        }

        #region 属性
        private LoginModel _loginInfo;
        public LoginModel LoginInfo 
        {
            get { return _loginInfo; }
            set { _loginInfo = value; RaisePropertyChanged();}
        }

        private bool toClose = false;
        /// <summary>
        /// 是否要关闭窗口
        /// </summary>
        public bool ToClose
        {
            get
            {
                return toClose;
            }
            set
            {
                if (toClose != value)
                {
                    toClose = value;
                    this.RaisePropertyChanged("ToClose");
                }
            }

        }

        /// <summary>
        /// 登陆指令
        /// </summary>
        public DelegateCommand LogInCommand { get; private set; }
        /// <summary>
        /// 关闭
        /// </summary>
        public DelegateCommand CloseCommand { get; private set; }
        /// <summary>
        /// 登陆加载
        /// </summary>
        public DelegateCommand LoadDataCommand { get; private set; }
        #endregion

        /// <summary>
        /// 关闭登陆
        /// </summary>
        private void CloseSignIn()
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// 登录
        /// </summary>
        private void SignIn() 
        {
            try
            {
                App.Current.Dispatcher.BeginInvoke((Action)(async () =>
                {
                    if (string.IsNullOrWhiteSpace(LoginInfo.Account) || string.IsNullOrWhiteSpace(LoginInfo.Pwd))
                    {
                        LoginInfo.Warning = "请输入账号和密码!";
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(LoginInfo.Account) && !string.IsNullOrWhiteSpace(LoginInfo.Pwd))
                    {
                        //SignIn objSignin = new SignIn();
                        //var LoginTask = Task.Run(() => objSignin.AccountLogin(LoginInfo.Account, LoginInfo.Pwd));

                        var timeouttask = Task.Delay(3000);
                        //var task = await Task.WhenAny(LoginTask, timeouttask);

                        //if (task == timeouttask)
                        //{
                        //    LoginInfo.Warning = "系统连接超时,请联系管理员!";
                        //}
                        //else
                        //{
                            if (LoginInfo.UserChecked) SaveLoginInfo();
                            //var data = LoginTask.Result;
                            //var userList = data;
                            //var success = data.msg.ToString();
                            //if (success != null)
                            //{
                                ToClose = true;
                                return;
                            //}
                            //else
                            //{
                            //    LoginInfo.Warning = "账号或密码错误!";
                            //}
                        //}
                    }
                    else
                    {
                        LoginInfo.Warning = "密码或账号不能空！";
                        return;
                    }
                }));
            }
            catch (Exception ex)
            {
                LoginInfo.Warning = ex.ToString();
            }
        }

        /// <summary>
        /// 保存登录信息
        /// </summary>
        private void SaveLoginInfo()
        {
            string cfgINI = AppDomain.CurrentDomain.BaseDirectory + SerivceFiguration.INI_CFG;
            IniFiles ini = new IniFiles(cfgINI);
            ini.IniWriteValue("Login", "User", LoginInfo.Account);
            ini.IniWriteValue("Login", "Password", CEncoder.Encode(LoginInfo.Pwd));
            ini.IniWriteValue("Login", "SaveInfo", LoginInfo.UserChecked ? "Y" : "N");
        }
    }
}
