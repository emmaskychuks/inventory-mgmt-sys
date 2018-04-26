using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class Order // gets fulfilled by warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateOrdered { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Warehouse ShippedFrom { get; set; }
        
        public ICollection<OrderedItems> ItemsOrdered { get; set; }
    }


    
}
