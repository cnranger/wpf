using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Inventory.UI.Annotations;
using InventoryService;

namespace Inventory.UI
{
    class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            IExceptionHandler handler = new ExceptionHandler();

            IsBusy = true;

            IInventoryService service = new global::InventoryService.InventoryService();
            
            Vehicles = new ObservableCollection<InventoryItemViewModel>();
            var task = Task.Factory.StartNew(() => service.GetItems());
         //   TaskScheduler taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            task.ContinueWith(x =>
                {
                    if (x.IsFaulted || x.Exception != null)
                    {
                        handler.Handle(this, x.Exception);
                    }
                    else
                    {
                        foreach (var vehicle in x.Result)
                        {
                            Vehicles.Add(new InventoryItemViewModel(vehicle));
                        }
                    }
                    IsBusy = false;
                });
        }

        public ObservableCollection<InventoryItemViewModel> Vehicles { set; get; }

        private bool _isBusy;
        public bool IsBusy
        {
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
            get { return _isBusy; }
        }

        #region generated property change notification code

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
