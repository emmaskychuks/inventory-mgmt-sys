using InventoryClasses;
using InventoryClasses.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    static class BatchFileProcessor
    {
       
        public static void ProcessFile(string fileType, string fileLocation)
        {
            try
            {
                switch (fileType)
                {
                    case "VendorShipment":
                        ParseVendorShipmentFile(fileLocation);
                        break;
                    case "CustomerOrder":
                        ParseCustomerOrderFile(fileLocation);
                        break;
                    default:
                        break;
                }
            }
            catch(InvalidDataException e)
            {
                Console.WriteLine("{0} is a non-valid order type", fileLocation);
            }
        }

        //Helper Functions
        /// <summary>
        /// Description: This function only works on files with no spce in between lines of records
        /// </summary>
        private static void ParseVendorShipmentFile(string fileLocation)
        {
            //TODO: Find the object type to save to the database. Possibly Warehouse
            
            ItemCategory itemCategory = new ItemCategory();
            Vendor vendor = new Vendor();
            ItemStock itemStock = new ItemStock(); 
            bool vendorOrderExist = false;
            int sequenceNumber = 0;
            int counter = 1;
            int itemCategoryID;
            int vendorID;
            try
            {
                using (StreamReader streamReader = new StreamReader(fileLocation))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (vendorOrderExist && line.Substring(0, 1) != "T")
                        {
                            vendorID = Convert.ToInt32(line.Substring(0, 2));
                            line = line.Remove(0, 2);
                            itemCategoryID = Convert.ToInt32(line.Substring(0, 5));
                            vendor.ItemProvided = itemCategory;
                            itemStock.Quantity = Convert.ToInt32(line.Substring(2, 6));
                            //Validate Item
                            itemStock.ItemStored = itemCategory;
                            counter++;

                            /***
                             * Go to back order database and fufil all order.
                             * Distribute remaining to all seven warehouses
                             **/
                        }
                        else if (!vendorOrderExist && line.Substring(0, 2) == "HD")
                        {
                            vendorOrderExist = true;
                            sequenceNumber = Convert.ToInt32(line.Substring(3, 4));
                        }
                        else if (line.Substring(0, 1) == "T")
                        {
                            //Check total vendor items
                            vendorOrderExist = false;
                        }
                        else
                            throw new Exception();
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found in {0}", fileLocation);
            }
        }
        /// <summary>
        /// Reposnsible for parsing customer order from file
        /// </summary>
        private static void ParseCustomerOrderFile(string fileLocation)
        {
            string line;
            int sequence = 0;
            bool customerOrderExist = false;
            int orderCounter = 0;

            ItemCategory itemCategory = new ItemCategory();
            Vendor vendor = new Vendor();
            ItemStock itemStock = new ItemStock();
            Customer newCustomer = new Customer();
            Order order = new Order();
            OrderedItems orderedItems = new OrderedItems();
            int sequenceNumber = 0;

            try {
                using (StreamReader streamReader = new StreamReader(fileLocation))
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (customerOrderExist && line.Substring(0, 1) != "T")
                        {
                            switch(line[0])
                            {
                                case 'C':
                                    sequenceNumber = 0;
                                    order = new Order();
                                
                                    order.OrderCode = line.Substring(1, 6);
                                    line = line.Remove(0, 6);
                                    newCustomer.CustomerID = Convert.ToInt32(line.Substring(0, 5));
                                    line = line.Remove(0, 5);
                                    newCustomer.Name = line.Substring(0, 30).Trim();
                                    line = line.Remove(0, 30);
                                    newCustomer.Address = 
                                        line.Substring(0, 20).Trim()+ " " + line.Remove(0, 20).Substring(0, 20).Trim() + " " +
                                        line.Remove(0, 20).Substring(0, 2).Trim() + " " + line.Remove(0, 2).Substring(0, 9).Trim();
                                    break;
                                case 'I':
                                    itemCategory = new ItemCategory();
                                    itemCategory.ItemCategoryID = Convert.ToInt32(line.Substring(0, 5));
                                    line = line.Remove(0, 5);
                                    orderedItems.Quantity = Convert.ToInt32(line.Substring(0, 5));
                                    orderedItems.OrderedItemsID = itemCategory.ItemCategoryID; //TODO: Needs review
                                    //orderedItems.ItemStored = itemCategory;
                                    ///.order = order;
                                    order.ItemsOrdered.Add(orderedItems);
                                    //Discount code not needed from file
                                    orderCounter++;
                                    break;
                                case 'L':
                                    //Check if Warehouse have Item Quantity
                                    //Create back order if needed
                                    //Save Order
                                    int numberOfOrderedItems = Convert.ToInt32(line.Substring(1, 3));
                                    if (orderCounter != numberOfOrderedItems)
                                    {
                                       //Missed an ordered item
                                    }
                                    orderCounter = 0;
                                    break;
                                case 'O':
                                    customerOrderExist = false;
                                    //Can also be used to keep track of number of customers
                                    break;
                                default:
                                    throw new InvalidDataException();

                            }
                        }
                        else if (!customerOrderExist && line.Substring(0, 2) == "HD")
                        {
                            sequence = Convert.ToInt32(line.Substring(3, 4));
                            orderCounter = 1;
                            customerOrderExist = true;
                        }
                        else if (line.Substring(0, 1) == "T")
                        {
                            //TODO: Check Data Records Number
                            break;
                        }
                        else
                            throw new Exception();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found in {0}", fileLocation);
            }
        }

        private static void CheckOrderedItems()
        {
            //Iterate through warehouses are find items that can be placed on needs to be placed in back order
            Dictionary<ItemCategory, int> backOrderItemsAndQuantities = new Dictionary<ItemCategory, int>();
        }
        public static void BackOrderOperation(int remainingQuantity, ItemCategory item)
        {
            InvContext ctx = new InvContext();
            BackOrder backOrder = new BackOrder();

        }

        

    }
}
