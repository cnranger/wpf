using System;
using System.Collections.Generic;
using System.Windows;
using InventoryService;

namespace Inventory.UI
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

            IExceptionHandler handler =new ExceptionHandler();

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

    public static class Settings
    {
        public static readonly Dictionary<Type, Tuple<string, string>> Mapping = new Dictionary<Type, Tuple<string, string>>();
      
    }

}
