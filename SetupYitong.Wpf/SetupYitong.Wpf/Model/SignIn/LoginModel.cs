using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.SignIn
{
    public class LoginModel:BindableBase
    {
        /// <summary>
        /// 账号
        /// </summary>
        private string _account = "admin";
        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 密码
        /// </summary>
        private string _pwd = "123456";
        public string Pwd
        {
            get { return _pwd; }
            set
            {
                _pwd = value;
                RaisePropertyChanged();
            }

        }

        /// <summary>
        /// 记住密码
        /// </summary>
        private bool _UserChecked;
        public bool UserChecked
        {
            get { return _UserChecked; }
            set { _UserChecked = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 错误提示信息
        /// </summary>
        private string _warning;
        public string Warning
        {
            get { return _warning; }
            set
            {
                _warning = value;
                RaisePropertyChanged();
            }
        }
    }
}
