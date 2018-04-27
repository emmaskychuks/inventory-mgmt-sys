using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace InventoryClasses.Entities
{
    [Table("Orders")]
    public class Order
    {

        // ------------ Attributes
        /// <summary>
        /// 
        /// </summary>
        [Column("OrderID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("OrderCode"), Display(Name = "Order Code"), StringLength(6, ErrorMessage = "Order Code must be 3 letters and 3 numbers ")]
        public string OrderCode { get; set; }

        /// <summary>
        /// The date that the order was processed
        /// </summary>
        [Required]
        public DateTime DateOrdered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Customer")]
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// NOTICE: this collection does not require OrderedItems objects to have a literal Order reference
        /// Performs an automatic foriegn key lookup in the OrderedItems table
        /// </summary>
        [Required]
        public ICollection<OrderedItems> ItemsOrdered { get; set; } = new List<OrderedItems>();


        // ------------ Functions

        
        /// <summary>
        /// Adds an item with x quantity to the ordered list, but does NOT save
        /// </summary>
        public bool AddItemToOrder(ItemCategory item, int quantity)
        {
            if (ItemsOrdered == null)
            {
                
            }
            else if (ItemsOrdered.Any(x => x.Item == item))
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

        /// <summary>
        /// Submit the order - save to the database (still editable). 
        /// </summary>
        /// <returns></returns>
        public bool Submit()
        {

            if (this.ItemsOrdered.Count == 0)
            {
                Statics.DebugOut("Error: cannot submit an order without an items");
                return false;
            }


            using (InvContext ctx = new InvContext())
            {
                // ensure the context knows about this item in reference to the database
                //ctx.Orders.Attach(this);

                ctx.Entry(this).State = this.OrderID == default(int) ? EntityState.Added : EntityState.Modified;
                

                // tell the database that this item already exists or needs to be added

                this.DateOrdered = DateTime.Now;
                this.OrderCode = "ABC" + Statics.rand.Next(0, 999).ToString().PadLeft(3, '0');

                ctx.SaveChanges();
            }

            return true;
        }
        
    }



}
