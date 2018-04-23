using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class Warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseID { get;set; }

        public string Name { get; set; }
        public string Address { get; set; }



        public Dictionary<ItemCategory, int> ItemsStored;


        private bool CreateBackOrder()
        {
            throw new NotImplementedException();
            return false;
        }



    }
}
