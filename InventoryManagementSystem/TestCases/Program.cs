using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses.Entities;
using InventoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    class Program
    {
        static void Main(string[] args) // test each use case
        {
            Console.WriteLine("INFO - Taking sample customer and items");
            Customer testCustomer = null;
            List<ItemCategory> itemsToOrder = new List<ItemCategory>();

            // start with a customer and items to order
            using (InvContext ctx = new InvContext())
            {
                testCustomer = ctx.Customers.FirstOrDefault();
                itemsToOrder = ctx.ItemCategories.ToList();
            }

            Console.WriteLine("INFO - Asserting we have a customer and items");
            Debug.Assert(testCustomer != null, "Requires customer in database");
            Debug.Assert(itemsToOrder != null, "Requires items in database");


            // create a bunch of random orders // THIS SHOULD BE PART OF THE ITEM SHOPPING
            Console.WriteLine("INFO - Creating shopping cart order");
            var testOrder = new Order()
            {
                Customer = testCustomer, // changing customers can wipe out this shopping cart
            };


            // emulate the customer shopping
            // populate the shopping cart with random item and quantities
            Console.WriteLine("INFO - Filling shopping cart");
            for (int i = 0; i < 10; i++)
            {
                ItemCategory randomItem = itemsToOrder[Statics.rand.Next(0, itemsToOrder.Count)];
                var randomQuantity = Statics.rand.Next(0,100);
                testOrder.AddItemToOrder(randomItem, randomQuantity);
            }

            Console.WriteLine("INFO - Submitting Order to database");
            testOrder.Submit();

            // submit the order and make sure that its fields are filled correctly
            Console.WriteLine("INFO - Asserting order is filled correctly");
            Debug.Assert(testOrder.DateOrdered != null);
            Debug.Assert(testOrder.OrderCode != null);
            Debug.Assert(testOrder.ItemsOrdered.Count > 0);



            Console.WriteLine("Congrats if youre seeing this you passed all the tests so far.");
            Console.WriteLine("Pres <enter> to quit.");
            Console.ReadLine();

        }


    }
}
