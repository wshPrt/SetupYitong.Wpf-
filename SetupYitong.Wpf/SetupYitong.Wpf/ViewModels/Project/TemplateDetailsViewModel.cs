using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 模版详情vm
    /// </summary>
    public class TemplateDetailsViewModel : BindableBase, IDialogAware
    {
        public TemplateDetailsViewModel()
        {
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", TitleText = "三维动画", ContentText = "适用于三维动画制作模版" });
        }

        #region 属性
        public class CardModel
        {
            public string ImageURI { get; set; } = "";
            public string TitleText { get; set; } = "";
            public string ContentText { get; set; } = "";
        }
        public List<CardModel> CardList { get; set; } = new List<CardModel>();
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
        #endregion
    }
}
