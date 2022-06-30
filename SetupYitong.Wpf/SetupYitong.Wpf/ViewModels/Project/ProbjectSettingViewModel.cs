using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
    /// <summary>
    /// 项目设置VM
    /// </summary>
    public class ProbjectSettingViewModel : BindableBase
    {
        public ProbjectSettingViewModel()
        {
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "三维动画", RightText = "222" });
        }

        #region 属性
        public class CardModel
        {
            public string ImageURI { get; set; } = "";
            public string LeftText { get; set; } = "";
            public string RightText { get; set; } = "";
        }
        public List<CardModel> CardList { get; set; } = new List<CardModel>();
        #endregion
    }
}
