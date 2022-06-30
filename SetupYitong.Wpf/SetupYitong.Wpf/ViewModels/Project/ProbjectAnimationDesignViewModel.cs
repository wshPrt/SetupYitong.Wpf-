using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SetupYitong.Wpf.Interface;
using SetupYitong.Wpf.Model.Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 項目>动画设计VM
    /// </summary>
   public class ProbjectAnimationDesignViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogHostService _dialogHost;
        public ProbjectAnimationDesignViewModel(IRegionManager regionManager, IDialogHostService dialogHost)
        {
            this._regionManager = regionManager;
            this._dialogHost = dialogHost;
            GoBackProjectCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("Project");
            });
            InitTaskInfo();
            NewProcessCommand = new DelegateCommand(NewProcess);
            NewTaskCommand = new DelegateCommand<string>(arg =>
            {
                regionManager.Regions["MainRegion"].RequestNavigate("NewTask");
                //regionManager.Regions["MainRegion"].RequestNavigate("NewGeneralTask");

            });
            DetailsCommand = new DelegateCommand(OpenDetails);
        }
       /// <summary>
       /// 任务列表
       /// </summary>
     public DelegateCommand<string> GoBackProjectCommand { get; private set; }

        private ObservableCollection<TaskListModel> _taskList;
        public ObservableCollection<TaskListModel> TaskList
        {
            get { return _taskList; }
            set { _taskList = value; RaisePropertyChanged(); }
        }
        public DelegateCommand NewProcessCommand { get; private set;}
        /// <summary>
        /// 新建任务
        /// </summary>
        public DelegateCommand <string> NewTaskCommand { get; private set; }
        /// <summary>
        /// 打开动画详情
        /// </summary>
        public DelegateCommand DetailsCommand { get; private set; }
        private async void InitTaskInfo()
        {
            await Task.Run(() =>
            {
                TaskList = new ObservableCollection<TaskListModel>()
                 {
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景1号",
                        LensTime = "3s",
                        FinishTime ="2022.01.19",
                        Personnel ="陈晓明",
                        Progress ="进行中",
                        ReadState ="已读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景2号",
                        LensTime = "3s",
                        FinishTime ="2022.01.19",
                        Personnel ="王小小",
                        Progress ="进行中",
                        ReadState ="已读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景3号",
                        LensTime = "3s",
                        FinishTime ="2022.01.19",
                        Personnel ="王立松",
                        Progress ="未开始",
                        ReadState ="未读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景4号",
                        LensTime = "3s",
                        FinishTime ="2021.11.11",
                        Personnel ="李万良",
                        Progress ="已完成",
                        ReadState ="已读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景5号",
                        LensTime = "3s",
                        FinishTime ="2021.12.18",
                        Personnel ="李晓丹",
                        Progress ="进行中",
                        ReadState ="已读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景6号",
                        LensTime = "3s",
                        FinishTime ="2021.11.11",
                        Personnel ="李万良",
                        Progress ="已逾期",
                        ReadState ="已读"
                    },
                    new TaskListModel()
                    {
                        SerialNumber = "cam1-大场景7号",
                        LensTime = "3s",
                        FinishTime ="2021.11.11",
                        Personnel ="李晓彤",
                        Progress ="进行中",
                        ReadState ="已读"
                    },
                 };
            });
        }

        private void OpenDetails()
        {
            _dialogHost.ShowDialogAsync("AnimationDetails", null);
        }
        private void NewProcess() 
        {
            _dialogHost.ShowDialogAsync("NewProcess", null);
        }
    }
}
