using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        

        public Order PlaceOrder(Dictionary<ItemCategory, int> orderedItems)
        {
            throw new NotImplementedException();
        }
        public Order EditOrder(Order originalOrder)
        {
            throw new NotImplementedException();
        }
        public bool CancelOrder(Order originalOrder)
        {
            throw new NotImplementedException();
        }

        public void ViewOrder(Order viewOrder)
        {
            throw new NotImplementedException();
        }


    }
}
