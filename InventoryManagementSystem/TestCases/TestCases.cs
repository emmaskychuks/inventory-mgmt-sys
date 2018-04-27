using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses.Entities;

namespace TestCases
{
    public static class TestCases
    {


        public static class OrderTests
        {
            public static List<Order> GetListOfValidOrders()
            {
                return null;
                throw new NotImplementedException();
            }

            public static List<Order> GetListOfInvalidOrders()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Test this and that and make sure these things do this
            /// </summary>
            public static bool PlaceValidOrderTest()
            {
                GetListOfValidOrders();
                Debug.Assert(true);
                return false;
            }

            /// <summary>
            /// Order should not go through if the time is between midnight and 7am
            /// </summary>
            /// <returns></returns>
            public static bool PlaceOrderBetweenMidnightAndSeven()
            {
                Debug.Assert(false);
                return false;
            }





        }




    }
}
