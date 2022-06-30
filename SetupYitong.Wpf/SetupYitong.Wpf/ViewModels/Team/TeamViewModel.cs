using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using SetupYitong.Commons.Base;
using SetupYitong.Wpf.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 团队VM
    /// </summary>
    public class TeamViewModel: NotifyPropertyBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public TeamViewModel(IRegionManager regionManager, IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            TabChangedCommand = new CommandBase(OnTabChanged);
            OnTabChanged("SetupYitong.Wpf.Views.MembersManage");
            InviteUserCommand = new DelegateCommand(OpenInvitedUsers);
            ImportUserCommand = new DelegateCommand(OpenImportUser);
        }
        #region 属性
        private UIElement _manageContent;
        public UIElement ManageContent
        {
            get { return _manageContent; }
            set
            {
                Set<UIElement>(ref _manageContent, value);
            }
        }
        public CommandBase TabChangedCommand { get; set; }
        /// <summary>
        /// 打开邀请用户
        /// </summary>
        public DelegateCommand InviteUserCommand { get; private set; }
        /// <summary>
        /// 打开
        /// </summary>
        public DelegateCommand ImportUserCommand { get; private set; }
        #endregion

        private void OnTabChanged(object obj)
        {
            if (obj == null) return;
            // 简化方式，必须在同一个程序集下
            Type type = Type.GetType(obj.ToString());
            this.ManageContent = (UIElement)Activator.CreateInstance(type);
        }

        /// <summary>
        /// 打开邀请用户弹窗
        /// </summary>
        private void OpenInvitedUsers() 
        {
            _dialogHost.ShowDialogAsync("InvitedUsers", null);
        }
        /// <summary>
        /// 打开批量导入用户
        /// </summary>
        private void OpenImportUser() 
        {
            _dialogHost.ShowDialogAsync("ImportUser", null);
        }
    }
}
