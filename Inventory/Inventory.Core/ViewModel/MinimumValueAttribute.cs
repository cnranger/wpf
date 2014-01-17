using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.ViewModel
{
    public class MinimumValueAttribute : ValidatorAttributeBase
    {
        private int _minimum;

        public MinimumValueAttribute(int minimum)
        {
            _minimum = minimum;
        }

        public override string Validate(Type propertyType, object value)
        {
            if (value != null && int.Parse(value.ToString()) < _minimum)
            {
                return string.Format("Minimum value is {0}, but the supplied value is {1}.", _minimum, value);
            }
            else
            {
                return null;
            }
        }
    }
}
