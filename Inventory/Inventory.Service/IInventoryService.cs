using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public interface IInventoryService
    {
        IEnumerable<InventoryItem> GetItems();
    }
}


