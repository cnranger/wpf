using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Inventory.Core.Reflection;

namespace Inventory.UI.Converters
{
    class VehiclePropertiesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;

            var list = new List<DictionaryEntry>();
            foreach (var property in value.GetType().GetProperties().Where(x => x.IsPrimaryOrString() && x.Name != "PhotoName").OrderBy(x=>x.Name))
            {
                list.Add(new DictionaryEntry(property.Name, property.GetValue(value, new object[]{})));
            }

            return list;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
