using Prism.Mvvm;
using SetupYitong.Wpf.Model.Team;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 部门管理VM
    /// </summary>
    public class DepartmentManageViewModel: BindableBase
    {
        public DepartmentManageViewModel()
        {
            InitDepartment();
        }
         
        #region 属性
        private ObservableCollection<DepartmentModel> _departmentList;
        public ObservableCollection<DepartmentModel> DepartmentList
        {
            get { return _departmentList; }
            set { _departmentList = value;RaisePropertyChanged();}
        }
        #endregion

        private void InitDepartment() 
        {
            DepartmentList = new ObservableCollection<DepartmentModel>()
            {
                new DepartmentModel(){DepartName = "原画部",DepId=0},
                new DepartmentModel(){DepartName = "平面设计部",DepId=1},
                new DepartmentModel(){DepartName = "创意设计部",DepId=2},
                new DepartmentModel(){DepartName = "技术计部",DepId=3},
                new DepartmentModel(){DepartName = "产品运维部",DepId=4},
            };
        }
    }
}
