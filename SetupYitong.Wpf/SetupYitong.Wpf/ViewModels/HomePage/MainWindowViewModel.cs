using Prism.Mvvm;

namespace SetupYitong.Wpf.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "设艺通";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
