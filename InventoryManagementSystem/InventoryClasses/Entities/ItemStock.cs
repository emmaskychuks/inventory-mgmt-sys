using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class ItemStock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemStockID { get; set; }

        public Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
        public ItemCategory ItemStored { get; set; }
    }
}
