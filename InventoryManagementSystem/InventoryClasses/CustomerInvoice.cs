using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses
{
    public class CustomerInvoice
    {
        private int CustomerInvoiceID { get; set; }

        // if we change the order we dont want the items changing? or deletion


        // beter way to keep a permenant record or items from each?
        public Order FulfilledOrder { get; set; }
        public BackOrder UnfulfilledOrder { get; set; }


        public decimal TotalPrice { get; set; }
        public decimal SalesTax { get; set; }
        public decimal OrgPrice { get; set; }
        




    }
}
