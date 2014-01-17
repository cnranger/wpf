using System;
using System.Globalization;
using System.Windows.Data;
using InventoryService;

namespace Inventory.UI.Converters
{
    class TypeToTypeNameConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var vehicle = value as Vehicle;

            if (vehicle != null)
            {
                Type type = value.GetType();
                if (Settings.Mapping.ContainsKey(type))
                {
                   return Settings.Mapping[type].Item1;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
