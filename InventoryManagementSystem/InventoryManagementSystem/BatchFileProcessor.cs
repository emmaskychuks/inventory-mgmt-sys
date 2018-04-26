using InventoryClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class BatchFileProcessor
    {
        public string fileLocation { get; set; }
        public string fileType { get; set; }
        public StreamReader streamReader;
        public int sequenceNumber { get; set; }
        public BatchFileProcessor(string fileLocation, string fileType)
        {
            this.fileLocation = fileLocation;
            this.fileType = fileType;
            streamReader = new StreamReader(fileLocation);
        }
        public void ProcessFile()
        {
            try
            {
                switch (fileType)
                {
                    case "VendorShipment":
                        ParseVendorShipmentFile();
                        break;
                    case "CustomerOrder":
                        ParseCustomerOrderFile();
                        break;
                    default:
                        break;
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found in {0}", fileLocation);
            }
        }

        //Helper Functions
        /// <summary>
        /// Description: This function only works on files with no spce in between lines of records
        /// </summary>
        private void ParseVendorShipmentFile()
        {
            //TODO: Find the object type to save to the database. Possibly Warehouse
            
            ItemCategory itemCategory = new ItemCategory();
            Vendor vendor = new Vendor();
            ItemStock itemStock = new ItemStock(); 
            bool vendorOrderExist = false;
            int sequenceNumber = 0;
            int counter = 1;
            try
            {
                using (streamReader)
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        if (vendorOrderExist && line.Substring(0, 1) != "T")
                        {
                            vendor.VendorID = Convert.ToInt32(line.Substring(0, 2));
                            itemCategory.ItemCategoryID = Convert.ToInt32(line.Substring(2, 5));
                            itemCategory.Vendor = vendor.VendorID;
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
        private void ParseCustomerOrderFile()
        {
            string line;
            int sequence = 0;
            bool customerOrderExist = false;
            int counter = 0;

            ItemCategory itemCategory = new ItemCategory();
            Vendor vendor = new Vendor();
            ItemStock itemStock = new ItemStock();
            Customer newCustomer = new Customer();
            Order order = new Order();

            try {
                using (streamReader)
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (customerOrderExist && sequenceNumber == counter)
                        {
                            switch(line[0])
                            {
                                case 'C':
                                    order = new Order();

                                    order.OrderNumber = line.Substring(1, 6);
                                    newCustomer.CustomerID = Convert.ToInt32(line.Substring(6, 5));
                                    newCustomer.Name = line.Substring(11, 30).Trim();
                                    newCustomer.Address = 
                                        line.Substring(41, 20).Trim()+ " " + line.Substring(61, 20).Trim() + " " +
                                        line.Substring(81, 2).Trim() + " " + line.Substring(83, 9).Trim();
                                    break;
                                case 'I':
                                    itemCategory = new ItemCategory();
                                    itemCategory.ItemCategoryID = Convert.ToInt32(line.Substring(0, 5));
                                    order.ItemsOrdered.Add(itemCategory, Convert.ToInt32(line.Substring(5, 5)));
                                    counter++;
                                    break;
                                case 'L':
                                    //Save Order
                                    int numberOfOrderedItems = Convert.ToInt32(line.Substring(1, 3));
                                    if (counter != numberOfOrderedItems)
                                    {
                                       //Missed an ordered item
                                    }
                                    counter = 0;
                                    break;
                                case 'O':
                                    customerOrderExist = false;
                                    //Can also be used to keep track of number of orders
                                    break;
                                default:
                                    throw new InvalidDataException();

                            }
                        }
                        else if (!customerOrderExist && line.Substring(0, 2) == "HD")
                        {
                            sequence = Convert.ToInt32(line.Substring(3, 4));
                            counter = 1;
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
    }
}
