using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class ItemStock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemStockID { get; set; }

        public virtual Warehouse Warehouse { get; set; }
        public int Quantity { get; set; }
        public virtual ItemCategory ItemStored { get; set; }

        /// <summary>
        /// This is the percent of item type at each warehouse, ie 10% are warehouse 1, 90% are warehouse 2
        /// </summary>
        [NotMapped]
        public int DistributionField { get; set; }
    }
}
