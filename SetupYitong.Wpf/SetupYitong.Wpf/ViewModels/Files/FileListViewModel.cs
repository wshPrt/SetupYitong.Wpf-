using Prism.Mvvm;
using SetupYitong.Wpf.Model.Files;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 文件详情VM
    /// </summary>
   public class FileListViewModel : BindableBase
    {
        public FileListViewModel()
        {
          
            InitFileInfo();
        }

        private ObservableCollection<FileInfoModel> _fileInfoList;
        public ObservableCollection<FileInfoModel> FileInfoList
        {
            get { return _fileInfoList; }
            set { _fileInfoList = value; RaisePropertyChanged();}
        }
        /// <summary>
        /// 加载DataGrid
        /// </summary>
        private async void InitFileInfo() 
        {
            await Task.Run(() =>
             {
                 FileInfoList = new ObservableCollection<FileInfoModel>()
                 {
                    new FileInfoModel()
                    {
                         FileNameURL ="/Resource/Image/file.png",
                         FileName="参考资料",
                         CurrentState= "/Resource/Image/check.png", 
                         FileSize="123.4MB",
                         ModifyTime= DateTime.Now.ToString("yyyy-MM-dd"),
                         Details ="/Resource/Image/text.png"
                    },
                    new FileInfoModel()
                    {
                         FileNameURL ="/Resource/Image/file.png",
                         FileName="成果文件",
                         CurrentState= "/Resource/Image/check.png",
                         FileSize="123.4MB",
                         ModifyTime= DateTime.Now.ToString("yyyy-MM-dd"),
                         Details ="/Resource/Image/text.png"
                    },
                    new FileInfoModel()
                    {
                         FileNameURL ="/Resource/Image/word.png",
                         FileName="需求文档.docx",
                         CurrentState= "/Resource/Image/lock.png",
                         FileSize="123.4MB",
                         ModifyTime= DateTime.Now.ToString("yyyy-MM-dd"),
                         Details ="/Resource/Image/text.png"
                    },
                    new FileInfoModel()
                    {
                         FileNameURL ="/Resource/Image/excel.png",
                         FileName="需求列表.xls",
                         CurrentState= "/Resource/Image/sync.png",
                         FileSize="23.2KB",
                         ModifyTime= DateTime.Now.ToString("yyyy-MM-dd"),
                         Details ="/Resource/Image/text.png"
                    },
                    new FileInfoModel()
                    {
                        FileNameURL ="/Resource/Image/jpg.png",
                         FileName="建模效果.jpg",
                         CurrentState= "/Resource/Image/jpg.png",
                         FileSize="5.6MB",
                         ModifyTime= DateTime.Now.ToString("yyyy-MM-dd"),
                         Details ="/Resource/Image/text.png"
                    }
                 };
             });
        }
    }
}
