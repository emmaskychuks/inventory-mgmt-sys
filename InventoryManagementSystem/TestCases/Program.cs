using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses.Entities;

namespace TestCases
{
    class Program
    {
        static void Main(string[] args) // test each use case
        {
            TestCases.OrderTests.PlaceValidOrderTest();


            TestCases.OrderTests.PlaceOrderBetweenMidnightAndSeven();


        }







    }
}
