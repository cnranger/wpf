using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Inventory.UI.Converters
{
    class ImageUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;

            string convert = string.Format("../Images/{0}", value);
            return convert;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
