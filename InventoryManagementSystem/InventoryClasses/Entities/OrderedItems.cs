using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryClasses.Entities
{
    public class OrderedItems
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderedItemsID { get; set; }
        
        //public virtual Order order { get; set; } // this is only a foriegn key
        public int Quantity { get; set; }
        public virtual ItemCategory Item { get; set; }
        public virtual Order Order { get; private set; }

        public OrderedItems()
        {
        }

        public OrderedItems(ItemCategory item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }


        /// <summary>
        /// This is the percent of item type at each warehouse, ie 10% are warehouse 1, 90% are warehouse 2
        /// </summary>
        [NotMapped]
        public int DistributionField { get; set; }
    }
}
