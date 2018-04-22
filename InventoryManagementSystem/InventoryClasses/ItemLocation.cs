using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{

    [Obsolete("Just store the location name in the category")]
    public class ItemLocation
    {
        private int ItemLocationID { get; set; }
        public string LocationName { get; set; }
        public ItemCategory ItemStoredAtLocation { get; set; }
    }
}
