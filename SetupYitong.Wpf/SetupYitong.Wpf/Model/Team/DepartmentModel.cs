using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Team
{
    /// <summary>
    ///部门管理
    /// </summary>
   public class DepartmentModel:BindableBase
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        private int _depId;
        public int DepId
        {
            get { return _depId; }
            set { _depId = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        private string _departName;
        public string DepartName
        {
            get { return _departName; }
            set { _departName = value;RaisePropertyChanged();}
        }

    }
}
