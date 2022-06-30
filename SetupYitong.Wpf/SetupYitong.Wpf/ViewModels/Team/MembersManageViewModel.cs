using Prism.Commands;
using Prism.Mvvm;
using SetupYitong.Wpf.Interface;
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
    /// 成员管理VM
    /// </summary>
    public class MembersManageViewModel:BindableBase
    {
        private readonly IDialogHostService _dialogHost;
        public MembersManageViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            InitMembers();
            UserDetailsCommand = new DelegateCommand(OpenUserDetails);
        }
        #region 属性
        private ObservableCollection<MembersModel> _membersList;
        public ObservableCollection<MembersModel> MembersList
        {
            get { return _membersList; }
            set { _membersList = value; RaisePropertyChanged(); }
        }
        public DelegateCommand UserDetailsCommand { get; private set; }
        #endregion

        /// <summary>
        /// 加载DataGrid
        /// </summary>
        private void InitMembers() 
        {
            Task.Run(() =>
            {
               MembersList = new ObservableCollection<MembersModel>()
                {
                    new MembersModel()
                    {
                         Name = "李明明",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="高级原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "王晓丽",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="实习原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "李明明",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="高级原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "王晓丽",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="实习原画设计师"
                    },

                    new MembersModel()
                    {
                         Name = "李明明",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="高级原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "王晓丽",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="原画设计师"
                    },
                    new MembersModel()
                    {
                         Name = "陈辰",
                         Number ="123456",
                         PhoneNo = 1389999123,
                         Role ="部门经理",
                         Position ="实习原画设计师"
                    }
                };
            });
        }

        private void OpenUserDetails() 
        {
            _dialogHost.ShowDialogAsync("UserDetails", null);
        }
    }
}
