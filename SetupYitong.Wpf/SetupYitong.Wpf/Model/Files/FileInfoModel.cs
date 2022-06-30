using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.Model.Files
{
   /// <summary>
   /// 文件信息
   /// </summary>
   public class FileInfoModel:BindableBase
   {
        /// <summary>
        /// 文件名图片路径
        /// </summary>
        private string _fileNameURL;
        public string FileNameURL
        {
            get { return _fileNameURL; }
            set { _fileNameURL = value;RaisePropertyChanged();}
        }

        /// <summary>
        /// 文件名
        /// </summary>
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        private string _currentState;
        public string CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; RaisePropertyChanged();}
        }

        /// <summary>
        /// 文件大小
        /// </summary>
        private string _fileSize;
        public string FileSize 
        {
            get { return _fileSize; }
            set { _fileSize = value;RaisePropertyChanged();}
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
        /// 详情
        /// </summary>
        private string _details;
        public string Details
        {
            get { return _details; }
            set { _details = value; RaisePropertyChanged();}
        }
    }
}
