using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace MvvmCalculatorCs.Common
{
    class StringToNullableIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return string.Empty;
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString())) return null;
            int valueInt;
            if (Int32.TryParse(value.ToString(), out valueInt))
            {
                return valueInt;
            }
            return null;
        }
    }
}
