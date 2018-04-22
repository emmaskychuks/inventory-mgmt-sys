using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class PackingSlip
    {
        private int PackingSlipID { get; set; }
        public Customer CustomerToShipTo { get; set; }
        public Warehouse WarehouseToShipFrom { get; set; }
        public Dictionary<ItemCategory, int> GetOrderItems { get; set; }

        private Order OrderBeingPacked { get; set; }


        public string GenerateSlip()
        {
            throw new NotImplementedException();
            return "";
        }




    }
}
