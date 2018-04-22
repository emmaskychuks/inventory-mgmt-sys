using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class ItemCategory
    {
        private int ItemCategoryID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int RestockItemLimit { get; set; }
        public int MaxPerWarehouse { get; set; }
        public string LocationInWarehouse { get; set; }

        public ItemLocation GetLocation()
        {
            throw new NotImplementedException();
        }

    }
}
