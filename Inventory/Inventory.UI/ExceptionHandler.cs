using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.UI
{
    public interface IExceptionHandler
    {
        void Handle(object sender, Exception e);
    }

    public class ExceptionHandler: IExceptionHandler
    {
        public void Handle(object sender, Exception e)
        {
            // we may log the exception, and use an instance of IDialogService to report the error msg back to user. 

        }
    }
}
