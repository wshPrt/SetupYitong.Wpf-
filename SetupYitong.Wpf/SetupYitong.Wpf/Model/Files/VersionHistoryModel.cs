using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Files
{
    /// <summary>
    /// 版本历史
    /// </summary>
   public class VersionHistoryModel: BindableBase
    {
        /// <summary>
        /// ID
        /// </summary>
        private int _versionId;
        public int VersionId
        {
            get { return _versionId; }
            set { _versionId = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 修改人
        /// </summary>
        private string _modifyPeople;
        public string ModifyPeople 
        {
            get { return _modifyPeople; }
            set { _modifyPeople = value;RaisePropertyChanged();}
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        private string _modifyTime;
        public string ModifyTime
        {
            get { return _modifyTime; }
            set { _modifyTime = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 文件大小
        /// </summary>
        private string _fileSize;
        public string FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; RaisePropertyChanged();}
        }
    }
}
