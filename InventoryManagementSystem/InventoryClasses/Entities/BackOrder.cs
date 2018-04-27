using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class BackOrder // gets fulfulled by the dist. center
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BackOrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateOrdered { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Warehouse ShippedFrom { get; set; }

        // NOTICE: this collection does not require OrderedItems objects to have a literal Order reference
        // Performs an automatic foriegn key lookup in the OrderedItems table
        public ICollection<OrderedItems> ItemsOrdered { get; set; }


        /// <summary>
        /// Adds an item with x quantity to the ordered list, but does NOT save
        /// </summary>
        public bool AddItemToOrder(ItemCategory item, int quantity)
        {
            if (ItemsOrdered.Any(x => x.Item == item))
            {
                // add to the quantity if the item is already in the ordered list
                var itemInList = ItemsOrdered.First(x => x.Item == item);
                itemInList.Quantity += quantity;
            }
            else
            {
                ItemsOrdered.Add(new OrderedItems(item, quantity));
            }
            return true;
        }

        public BackOrder SaveBackOrder()
        {
            using (InvContext ctx = new InvContext())
            {
                ctx.BackOrders.Attach(this);
                ctx.SaveChanges();
            }
            return this;
        }
    }
}
