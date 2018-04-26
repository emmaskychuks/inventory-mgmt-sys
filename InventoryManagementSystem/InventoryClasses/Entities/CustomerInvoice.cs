using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses.Entities;

namespace InventoryClasses.Entities
{
    public class CustomerInvoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerInvoiceID { get; set; }
        public virtual Customer NewCustomer { get; set; }
        // if we change the order we dont want the items changing? or deletion


        // beter way to keep a permenant record or items from each?
        public virtual Order FulfilledOrder { get; set; }
        public virtual BackOrder UnfulfilledOrder { get; set; }


        public decimal TotalPrice { get; set; }
        public decimal SalesTax { get; set; }    //Assume 6% tax
        public decimal OrgPrice { get; set; }
       
    }
}
