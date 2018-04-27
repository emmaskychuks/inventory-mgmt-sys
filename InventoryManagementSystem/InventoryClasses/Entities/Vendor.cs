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


        public static bool AddVendor(string nameOfVendorToAdd, string nameOfItem)
        {
            using (InvContext context = new InvContext())
            {
                ItemCategory itemCategory = context.ItemCategories.FirstOrDefault(x => x.Name == nameOfItem);
                int quantity = context.ItemStocks.FirstOrDefault(x => x.ItemStored.Name == itemCategory.Name).Quantity;
                if (quantity <= 0)
                {
                    //New vendor
                    Vendor vendor = new Vendor();
                    vendor.Name = nameOfVendorToAdd;
                    vendor.ItemProvided = itemCategory;

                    context.Vendors.Add(vendor);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int DeleteVendor(int vendorID)
        {
            using (InvContext context = new InvContext())
            {
                Vendor vendor = context.Vendors.FirstOrDefault(x => x.VendorID == vendorID);
                if (vendor != null)
                {
                    int quantity = context.ItemStocks.FirstOrDefault(x => x.ItemStored.Name == vendor.ItemProvided.Name).Quantity;
                    //Delete Vendor
                    if (quantity <= 0)
                    {
                        context.Vendors.Remove(vendor);
                        context.SaveChanges();
                    }
                    else
                        return 2;
                }
                else
                {
                    return 1;
                }
                return 0;
            }
        }







    }
}
