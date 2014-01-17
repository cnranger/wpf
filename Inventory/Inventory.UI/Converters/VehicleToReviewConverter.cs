using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using InventoryService;

namespace Inventory.UI.Converters
{
    class VehicleToReviewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;

            var car = value as Car;

            if (car == null) return DependencyProperty.UnsetValue;

            return car.CompanyReview.ReviewText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
