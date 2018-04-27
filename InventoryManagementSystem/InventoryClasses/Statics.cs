using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses.Entities;

namespace InventoryClasses
{
    public static class Statics
    {
        public static string DBconnstr =>
            "Data Source=aknierie.database.windows.net;Initial Catalog=CIS375_InventoryManagement;Persist Security Info=True;User ID=cis375;Password=futureengineerslikeblackpanther123!";

        public static Random rand = new Random();

        public static bool DebugMode = true;

        public static void DebugOut(string message)
        {
            if (DebugMode)
                Console.WriteLine(message);
        }


        public static void sample()
        {
            using (InvContext context = new InvContext())
            {
                var futureOrders = context.Orders.Where(x => x.DateOrdered > DateTime.Now).ToList();

                var myTestitem = new Order();



                context.Orders.Add(myTestitem);


                context.Orders.Attach(myTestitem);


                foreach (var order in futureOrders)
                {
                    context.Orders.Remove(order);

                }
                context.SaveChanges();
                

            }
            

        }
    }

}
