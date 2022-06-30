using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Team
{
    /// <summary>
    /// 成员管理
    /// </summary>
   public class MembersModel: BindableBase
   {
        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 工号
        /// </summary>
        private string _number;
        public string Number 
        {
            get { return _number; }
            set { _number = value;RaisePropertyChanged();}
        }
        private int _phoneNo;
        public int PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 角色
        /// </summary>
        private string _role;
        public string Role
        {
            get { return _role; }
            set { _role = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 职位
        /// </summary>
        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value;RaisePropertyChanged();}
        }
    }
}