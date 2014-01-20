using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.App
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App my = new App();

            Bootstrapper bs = new Bootstrapper();
            bs.Run();


            Window mainWindow = Application.Current.MainWindow;
            my.Run( mainWindow);

        }
    }
}
