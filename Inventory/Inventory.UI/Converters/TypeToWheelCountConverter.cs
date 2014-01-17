using System;
using System.Globalization;
using System.Windows.Data;
using InventoryService;

namespace Inventory.UI.Converters
{
    class TypeToWheelCountConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var vehicle = value as Vehicle;

            if (vehicle != null)
            {
                Type type = value.GetType();
                string propertyName;
                if (Settings.Mapping.ContainsKey(type))
                {
                    propertyName = Settings.Mapping[type].Item2;

                    if (propertyName != null)
                    {
                        var propertyInfo = type.GetProperty(propertyName);

                        return propertyInfo.GetValue(value, new object[] {});
                    }
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
