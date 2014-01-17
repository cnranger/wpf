using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Inventory.UI.Converters
{
    class InvertBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;

            bool boo;
            if (bool.TryParse(value.ToString(), out boo))
            {
                return !boo;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
