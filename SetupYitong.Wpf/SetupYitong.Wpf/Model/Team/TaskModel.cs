using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Team
{
    /// <summary>
    /// 任务列表
    /// </summary>
   public class TaskModel:BindableBase
    {
        /// <summary>
        /// 任务标题
        /// </summary>
        private string _stateTitle;
        public string StateTitle
        {
            get { return _stateTitle; }
            set { _stateTitle = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 任务状态
        /// </summary>
        private int _taskState;
        public int TaskState
        {
            get { return _taskState; }
            set { _taskState = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 任务名称
        /// </summary>
        private string _taskName;
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value;RaisePropertyChanged();}
        }
      

    }
}
