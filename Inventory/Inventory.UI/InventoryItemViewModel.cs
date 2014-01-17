using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.ViewModel;
using InventoryService;

namespace Inventory.UI
{
    internal class InventoryItemViewModel : ValidatedViewModelBase
    {
        private readonly InventoryItem _inventoryItem;

        public InventoryItemViewModel(InventoryItem inventoryItem)
        {
            _inventoryItem = inventoryItem;
        }

        [MinimumValue(0)]
        public int Quantity
        {
            get { return _inventoryItem.Quantity; }
            set { _inventoryItem.Quantity = value; }
        }

        public Vehicle Vehicle { get { return _inventoryItem.Vehicle; } }
    }
}
