using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SetupYitong.Commons.Converter
{
    /// <summary>
    /// 颜色转换器
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    public class ForegroundConverter : IValueConverter
    {
        //颜色状态: 1进行中，2已完成,3已逾期
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentNullException("value can not be null");

            if (value != null && int.TryParse(value.ToString(), out int result))
            {
                if (result > 0)
                {
                    if (result.Equals(1))
                    {
                        return "#FFD9EDFF";
                    }
                    else if (result.Equals(2))
                    {
                        return "#FFB6EAEA";
                    }
                    else if (result.Equals(3))
                    {
                        return "#FFFFEDD8";
                    }
                }
            }
            return "#FFF5F6F7";
        }
        //目标属性传给源属性时，调用此方法ConvertBack
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
