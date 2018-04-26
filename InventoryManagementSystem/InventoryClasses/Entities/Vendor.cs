using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class Vendor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorID { get; set; }
        public string Name { get; set; }


        public virtual ItemCategory ItemProvided { get; set; }


        public bool AddVendor()
        {
            throw new NotImplementedException();
        }
        public bool DeleteVendor()
        {
            throw new NotImplementedException();
        }







    }
}
