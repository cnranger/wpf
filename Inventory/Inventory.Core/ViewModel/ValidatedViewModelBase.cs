using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.ViewModel
{
   public class ValidatedViewModelBase : IDataErrorInfo
    {
        public string this[string propertyName]
        {
            get
            {
                var sb = new StringBuilder();
                var propInfo = this.GetType().GetProperty(propertyName);
                var value = propInfo.GetValue(this, new object[] { });
                var validationAttributes = propInfo.GetCustomAttributes(typeof(ValidatorAttributeBase), false);

                if (validationAttributes.Length > 0)
                {
                    foreach (ValidatorAttributeBase validationAttribute in validationAttributes)
                    {
                        string errMsg = validationAttribute.Validate(propInfo.PropertyType, value);

                        if (!string.IsNullOrEmpty(errMsg))
                            sb.AppendLine(errMsg);
                    }
                }

                var error = sb.ToString().TrimEnd('\r', '\n');
                return string.IsNullOrEmpty(error) ? null : error;
            }
        }

        public string Error { get; private set; }
    }
}
