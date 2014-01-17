using System;
using System.Globalization;
using System.Windows.Data;
using InventoryService;

namespace Inventory.UI.Converters
{
    class IsRoadVehicleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return false;

            VehicleEnvironment environment;

            if (Enum.TryParse(value.ToString(), out environment))
            {
                return environment == VehicleEnvironment.Land;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
