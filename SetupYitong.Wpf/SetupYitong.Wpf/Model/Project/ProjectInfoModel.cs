using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Project
{
    /// <summary>
    /// 项目相关信息
    /// </summary>
    public class ProjectInfoModel: BindableBase
    {
        /// <summary>
        /// 项目Id
        /// </summary>
        private int _probjectId;
        public int ProbjectId
        {
            get { return _probjectId; }
            set { _probjectId = value; RaisePropertyChanged();}
        }

        /// <summary>
        /// 项目名称
        /// </summary>
        private string _probjectName;
        public string ProbjectName 
        {
            get { return _probjectName;}
            set { _probjectName = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 项目分组
        /// </summary>
        private string _probjectGroup;
        public string ProbjectGroupp 
        {
            get { return _probjectGroup; }
            set { _probjectGroup = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 创建人
        /// </summary>
        private string _creator;
        public string Creator
        {
            get { return _creator; }
            set { _creator = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        private String _createTime ;
        public String CreateTime
        {
            get { return _createTime ; }
            set { _createTime  = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 项目开始时间
        /// </summary>
        private String _projectStartTime;
        public String ProjectStartTime
        {
            get { return _projectStartTime; }
            set { _projectStartTime = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 项目截止时间
        /// </summary>
        private String _probjectCutOffTime;
        public String ProbjectCutOffTime
        {
            get { return _probjectCutOffTime; }
            set { _probjectCutOffTime = value;RaisePropertyChanged();}
        }
    }
}
