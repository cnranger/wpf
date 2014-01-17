using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Reflection
{
    public static class PropertyInfoHelper
    {
        public static bool IsPrimaryOrString(this PropertyInfo propertyInfo)
        {
            return propertyInfo.PropertyType.IsPrimitive || propertyInfo.PropertyType.FullName == "System.String" || propertyInfo.PropertyType.IsEnum;
        }
    }
}
