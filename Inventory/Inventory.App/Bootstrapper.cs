using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Inventory.UI;
using Microsoft.Practices.Prism.UnityExtensions;

namespace Inventory.App
{
    class Bootstrapper : UnityBootstrapper 
    {
        protected override DependencyObject CreateShell()
        {
            return new MainWindow();
        }
    }
}
