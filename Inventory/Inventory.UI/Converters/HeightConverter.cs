using System;
using System.Globalization;
using System.Windows.Data;

namespace Inventory.UI.Converters
{
    /// <summary>
    /// because the auto row size doesn't auto change with the image inside, so we have to resize the row height manually  
    /// </summary>
    class HeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 100;
            else
            {
                return 250;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
