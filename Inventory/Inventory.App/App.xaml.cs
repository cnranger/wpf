using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Inventory.UI;
using InventoryService;

namespace Inventory.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            PopulateSettins();

            IExceptionHandler handler = new ExceptionHandler();

            Current.DispatcherUnhandledException += (sender, args) =>
            {
                handler.Handle(sender, args.Exception);
                args.Handled = true;
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var exception = args.ExceptionObject as Exception;
                if (exception != null)
                {
                    handler.Handle(sender, exception);
                }
                else
                {
                    // log the error
                }
            };
        }

        private void PopulateSettins()
        {
            var settings = new List<IMapper>
                {
                    new Mapper<Boat>("Boat", null),
                    new Mapper<Car>("Car", x=>x.NumberOfWheels),
                    new Mapper<Aeroplane>("Plane", x=>x.WheelCount)
                };

            foreach (var setting in settings)
            {
                Settings.Mapping.Add(setting.Type, new Tuple<string, string>(setting.TypeName, setting.WheelCountPropertyName));
            }
        }
    }

  

}
