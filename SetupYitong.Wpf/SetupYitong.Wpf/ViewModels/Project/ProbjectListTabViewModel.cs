using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupYitong.Wpf.ViewModels
{
  public class ProbjectListTabViewModel: BindableBase
    {
        public ProbjectListTabViewModel()
        {
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "动画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "原画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card3.png", LeftText = "建模设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card4.png", LeftText = "渲染设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card5.png", LeftText = "场景设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "人物设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "动画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card3.png", LeftText = "原画设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card4.png", LeftText = "建模设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card5.png", LeftText = "渲染设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card1.png", LeftText = "场景设计", RightText = "222" });
            CardList.Add(new CardModel { ImageURI = "/Resource/Image/card2.png", LeftText = "人物设计", RightText = "222" });
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
