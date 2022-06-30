using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetupYitong.Wpf.Controls
{
    /// <summary>
    /// MembersSeachTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class MembersSeachTextBox : UserControl
    {
        /// <summary>
        /// seach evevt
        /// </summary>
        public event Action<object, EventArgs> OnSearch;//第二个参数要是EventArgs
        public MembersSeachTextBox()
        {
            InitializeComponent();
        }

        private void _seachImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //OnSearchEvent?.Invoke(sender, e);
            OnSearch?.Invoke(this, e);
        }

        private void _closeImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _textBox.Text = "";
        }

        private void _textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (_textBox.Text != null && _textBox.Text.Length > 0)
            {
                _textBoxWater.Visibility = Visibility.Hidden;
                // _closeImage.Visibility = Visibility.Visible;
            }
            else
            {
                _textBoxWater.Visibility = Visibility.Visible;
                //_closeImage.Visibility = Visibility.Hidden;
            }
        }
        private void _textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_textBox.Text != null && _textBox.Text.Length > 0)
            {
                _textBoxWater.Visibility = Visibility.Hidden;
                // _closeImage.Visibility = Visibility.Visible;
            }
            else
            {
                _textBoxWater.Visibility = Visibility.Visible;
                //_closeImage.Visibility = Visibility.Hidden;
            }
        }
        private void _textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            _textBoxWater.Visibility = Visibility.Hidden;
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MembersSeachTextBox), new PropertyMetadata("", new PropertyChangedCallback(OnTextPropertyChangedCallback)));

        private static void OnTextPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is MembersSeachTextBox membersSeachTextBox)) return;
            if (!(e.NewValue is string text)) return;
            membersSeachTextBox._textBox.Text = text;
        }



        public new int Height
        {
            get { return (int)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public static new readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(int), typeof(MembersSeachTextBox), new PropertyMetadata(0, new PropertyChangedCallback(OnHeightPropertyChangedCallback)));

        private static void OnHeightPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is MembersSeachTextBox membersSeachTextBox)) return;
            if (!(e.NewValue is int height)) return;
            membersSeachTextBox._border.Height = height;
            membersSeachTextBox._border.CornerRadius = new CornerRadius(height / 4);

        }

        public new int Width
        {
            get { return (int)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        public static new readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(int), typeof(MembersSeachTextBox), new PropertyMetadata(0, new PropertyChangedCallback(OnWidthPropertyChangedCallback)));

        private static void OnWidthPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is MembersSeachTextBox membersSeachTextBox)) return;
            if (!(e.NewValue is int width)) return;
            membersSeachTextBox._border.Width = width;
        }
    }
}
