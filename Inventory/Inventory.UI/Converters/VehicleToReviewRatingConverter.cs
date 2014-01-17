using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using InventoryService;

namespace Inventory.UI.Converters
{
    class VehicleToReviewRatingConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;

            var item = value as InventoryItemViewModel;
            if (item == null) return DependencyProperty.UnsetValue;
            
            var car = item.Vehicle as Car;
            if (car == null || car.CompanyReview == null) return DependencyProperty.UnsetValue;

            return new object[car.CompanyReview.Rating];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
