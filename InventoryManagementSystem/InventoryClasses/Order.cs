using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class Order // gets fulfilled by warehouse
    {
        private int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateOrdered { get; set; }
        public Customer Customer { get; set; }
        public Warehouse ShippedFrom { get; set; }

        public Dictionary<ItemCategory, int> ItemsOrdered;
    }


    public class BackOrder : Order // gets fulfulled by the dist. center
    {


    }
}
