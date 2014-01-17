using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public class InventoryItem
    {
        public InventoryItem(Vehicle vehicle, int quantity)
        {
            Vehicle = vehicle;
            Quantity = quantity;
        }

        public int Quantity { get; set; }
        public Vehicle Vehicle { get; private set; }
    }
}

