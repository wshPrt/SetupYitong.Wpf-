using Prism.Mvvm;
using Prism.Services.Dialogs;
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
    /// 版本历史VM
    /// </summary>
   public class VersionHistoryViewModel: BindableBase,IDialogAware
    {
        public VersionHistoryViewModel()
        {
            InitVersionHistory();
        }
        #region 属性
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
        }
        /// <summary>
        /// 版本历史List
        /// </summary>
        private ObservableCollection<VersionHistoryModel> _versionHistoryList ;
        public ObservableCollection<VersionHistoryModel> VersionHistoryListList
        {
            get { return _versionHistoryList ; }
            set { _versionHistoryList  = value; RaisePropertyChanged();}
        }
        #endregion

        private void InitVersionHistory() 
        {
            Task.Run(() =>
            {
                VersionHistoryListList = new ObservableCollection<VersionHistoryModel>()
                {
                    new VersionHistoryModel(){ VersionId=0, ModifyPeople="王小初",ModifyTime= DateTime.Now.ToString("u"),FileSize="12.89M"},
                    new VersionHistoryModel(){ VersionId=1, ModifyPeople="王小初",ModifyTime= DateTime.Now.ToString("u"),FileSize="379.1kb"},
                    new VersionHistoryModel(){ VersionId=2, ModifyPeople="王小初",ModifyTime= DateTime.Now.ToString("u"),FileSize="499.3kb"},
                    new VersionHistoryModel(){ VersionId=3, ModifyPeople="王小初",ModifyTime= DateTime.Now.ToString("u"),FileSize="23.2kb"}
                };
            });
        }
    }
}
