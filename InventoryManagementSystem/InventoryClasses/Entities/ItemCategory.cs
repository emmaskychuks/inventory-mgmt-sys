using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class ItemCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemCategoryID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int RestockItemLimit { get; set; }
        public int Vendor { get; set; }
        public int MaxPerWarehouse { get; set; }
        public int DistributionField { get; set; }
        public string LocationInWarehouse { get; set; }

    }
}
