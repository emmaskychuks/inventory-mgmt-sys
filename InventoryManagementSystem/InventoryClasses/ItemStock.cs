using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class ItemStock
    {
        private int ItemStockID { get; set; }

        public Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
        public ItemCategory ItemStored { get; set; }
    }
}
