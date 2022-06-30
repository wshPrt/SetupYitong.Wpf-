using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Project
{
    /// <summary>
    /// 项目-动画设计-任务列表Model
    /// </summary>
   public class TaskListModel:BindableBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        private string _serialNumber;
        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 镜头时间
        /// </summary>
        private string lensTime;
        public string LensTime
        {
            get { return lensTime; }
            set { lensTime = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 完成时间
        /// </summary>
        private string _finishTime;
        public string FinishTime
        {
            get { return _finishTime; }
            set { _finishTime = value;RaisePropertyChanged();}
        }

        /// <summary>
        /// 人员
        /// </summary>
        private string _personnel;
        public string Personnel
        {
            get { return _personnel;}
            set { _personnel = value;RaisePropertyChanged(); }
        }
        /// <summary>
        /// 进度
        /// </summary>
        private string _progress;
        public string Progress
        {
            get { return _progress; }
            set { _progress = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 阅读状态
        /// </summary>
        private string _readState;
        public string ReadState
        {
            get { return _readState; }
            set { _readState = value;RaisePropertyChanged();}
        }

    }
}
