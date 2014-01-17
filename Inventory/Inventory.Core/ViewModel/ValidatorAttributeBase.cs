using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.ViewModel
{
    public abstract class ValidatorAttributeBase : Attribute
    {
        public abstract string Validate(Type propertyType, object value);
    }
}
