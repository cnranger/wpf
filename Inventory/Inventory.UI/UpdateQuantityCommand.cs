using System;
using System.Windows.Input;

namespace Inventory.UI
{
    class UpdateQuantityCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var item = parameter as InventoryItemViewModel;

            if (item == null) throw new ArgumentException("An instance of InventoryItemViewModel is expected as command parameter.");

            // at this point, we have everything we need to save the quantity
            // we just need the InventoryService to provide us a method to save the quantity. 
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
