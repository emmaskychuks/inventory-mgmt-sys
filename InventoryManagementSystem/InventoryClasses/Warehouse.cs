using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class Warehouse
    {
        private int WarehouseID { get;set; }

        public string Name { get; set; }
        public string Address { get; set; }



        private bool CreateBackOrder()
        {
            throw new NotImplementedException();
            return false;
        }



    }
}
