using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class Order // gets fulfilled by warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
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
