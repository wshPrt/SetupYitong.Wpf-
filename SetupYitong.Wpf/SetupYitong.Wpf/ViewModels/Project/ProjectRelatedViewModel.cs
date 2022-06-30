using Prism.Mvvm;
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
    /// 项目列表-相关信息VM
    /// </summary>
    public class ProjectRelatedViewModel : BindableBase
    {
        public ProjectRelatedViewModel()
        {
            InitProjectInfo();
        }

        private ObservableCollection<ProjectInfoModel> _projectInfoList;
        public ObservableCollection<ProjectInfoModel> ProjectInfoList
        {
            get { return _projectInfoList; }
            set { _projectInfoList = value; RaisePropertyChanged(); }
        }

        private async void InitProjectInfo()
        {
            await Task.Run(() =>
             {
                 ProjectInfoList = new ObservableCollection<ProjectInfoModel>()
                 {
                    new ProjectInfoModel()
                    {
                        ProbjectId = 0,
                        ProbjectName ="动画设计",
                        ProbjectGroupp = "建模类",
                        Creator = "李哲浩",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="原画设计",
                        ProbjectGroupp = "原画类",
                        Creator = "王小米",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="原画设计",
                        ProbjectGroupp = "原画类",
                        Creator = "王小米",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="建模设计",
                        ProbjectGroupp = "建模类",
                        Creator = "李哲浩",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 0,
                        ProbjectName ="动画设计",
                        ProbjectGroupp = "建模类",
                        Creator = "李哲浩",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="原画设计",
                        ProbjectGroupp = "原画类",
                        Creator = "王小米",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="原画设计",
                        ProbjectGroupp = "原画类",
                        Creator = "王小米",
                        CreateTime = DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    },
                     new ProjectInfoModel()
                    {
                        ProbjectId = 1,
                        ProbjectName ="建模设计",
                        ProbjectGroupp = "建模类",
                        Creator = "李哲浩",
                        CreateTime =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProjectStartTime  =DateTime.Now.ToString("yyyy-MM-dd"),
                        ProbjectCutOffTime =DateTime.Now.ToString("yyyy-MM-dd")
                    }
                 };
             });
        }
    }
}
