using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using SetupYitong.Wpf.Interface;
using SetupYitong.Wpf.Model.Team;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SetupYitong.Wpf.ViewModels
{
  /// <summary>
  /// 用户详情VM
  /// </summary>
   public class UserDetailsViewModel: BindableBase,IDialogAware
    {
        private readonly IDialogHostService _dialogHost;
        public UserDetailsViewModel(IDialogHostService dialogHost)
        {
            this._dialogHost = dialogHost;
            InitTaskList();
            DataModifyCommand = new DelegateCommand(OpenDataModify);
        }
        private async void InitTaskList() 
        {
           await Task.Run(() =>
            {
                App.Current.Dispatcher.BeginInvoke((Action)(() =>
               {
                   TaskList = new ObservableCollection<TaskModel>()
                {
                    new TaskModel()
                    {
                         TaskName="新建一个3D模型",
                          StateTitle= "进行中",
                          TaskState =1
                    },
                    new TaskModel()
                    {
                         TaskName="新建一个3D模型",
                         StateTitle= "进行中",
                         TaskState=1
                    },
                    new TaskModel()
                    {
                         TaskName="新建一个3D模型",
                         StateTitle= "已完成",
                         TaskState=2
                    },
                    new TaskModel()
                    {
                         TaskName="新建一个3D模型",
                         StateTitle= "已逾期",
                         TaskState= 3
                    },
                };
               }));
            });
        }

        #region 属性

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public string Title { get; set; }
        public event Action<IDialogResult> RequestClose;
        public bool CanCloseDialog()
        {
            return true;
        }
        public void OnDialogClosed()
        {
           
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }

        private ObservableCollection<TaskModel> _taskList;
        public ObservableCollection<TaskModel> TaskList
        {
            get { return _taskList; }
            set { _taskList = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 打开资料修改页
        /// </summary>
        public DelegateCommand DataModifyCommand { get; private set; }
        #endregion
        private void OpenDataModify() 
        {
            _dialogHost.ShowDialogAsync("DataModify", null);
        }
    }
}
