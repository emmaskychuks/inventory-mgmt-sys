using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClasses.Entities
{
    public class ItemCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemCategoryID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int RestockItemLimit { get; set; }
        
        public int MaxPerWarehouse { get; set; }
        
        public string LocationInWarehouse { get; set; }

        public void AddItem(string name, string description, string price, decimal distributionField)
        {
            using (InvContext context = new InvContext())
            {
                ItemCategory itemCategory = new ItemCategory();
                ItemStock itemStock = new ItemStock();
                itemCategory.Name = name;
                itemCategory.Price = Convert.ToDecimal(price);
                itemCategory.Description = description;

                itemStock.ItemStored = itemCategory;
                itemStock.Quantity = 0;
                context.SaveChanges();
            }
        }


    }
}
