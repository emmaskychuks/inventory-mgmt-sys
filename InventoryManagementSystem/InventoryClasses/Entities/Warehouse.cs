using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class Warehouse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseID { get;set; } 
        public string Name { get; set; }
        public string Address { get; set; }

        public IEnumerable<ItemStock> itemsStored;



        public static void CreateTestWarehouses()
        {
            using (InvContext ctx = new InvContext())
            {
                for (int i = 0; i < 7; i++)
                {
                    var newWarehouse = new Warehouse()
                    {
                        Address = $"Addres {i}00 Wares St.",
                        Name = "Warehouse " + i,
                        WarehouseID = i,
                    };

                    ctx.Warehouses.Add(newWarehouse);

                }
            }
        }

        public static int QuantityOfItemInEveryWareHouse(ItemCategory item)
        {
            //Quantity of a specified item from every warehouse
            using (InvContext ctx = new InvContext())
            {
                return 0;
            }
        }
        private bool CreateBackOrder()
        {
            throw new NotImplementedException();
            return false;
        }



    }
}
