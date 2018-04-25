using InventoryClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class FileParser
    {
        public string fileLocation { get; set; }
        public string fileType { get; set; }
        public StreamReader streamReader;
        public int sequenceNumber { get; set; }
        public FileParser(string fileLocation, string fileType)
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
                    case "VendorOrder":
                        ParseVendorOrderFile();
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
            bool newOrder = true;
            int counter = 1;
            try
            {
                using (streamReader)
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        int sequenceNumber = Convert.ToInt32(line.Substring(3, 4));
                        if (!newOrder && sequenceNumber == counter)
                        {
                            vendor.VendorID = Convert.ToInt32(line.Substring(0, 2));
                            itemCategory.ItemCategoryID = Convert.ToInt32(line.Substring(2, 5));
                            itemCategory.vendor = vendor;
                            itemStock.Quantity = Convert.ToInt32(line.Substring(2, 6));
                            itemStock.ItemStored = itemCategory;
                            counter++;
                        }
                        else if (newOrder && line.Substring(0, 2) == "HD")
                        {
                            newOrder = false;
                        }
                        else if (line.Substring(0, 1) == "T")
                        {
                            newOrder = true;
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

        private void ParseCustomerOrderFile()
        {
            string line;
            bool moreCustomerOrder = true;
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
                        if (moreCustomerOrder && sequenceNumber == counter)
                        {
                            int sequenceNumber = Convert.ToInt32(line.Substring(3, 4));
                            switch(line[0])
                            {
                                case 'C':
                                    order.OrderNumber = line.Substring(1, 6);
                                    newCustomer.CustomerID = Convert.ToInt32(line.Substring(6, 5));
                                    newCustomer.Name = line.Substring(11, 30).Trim();
                                    newCustomer.Address = 
                                        line.Substring(41, 20).Trim()+ " " + line.Substring(61, 20).Trim() + " " +
                                        line.Substring(81, 2).Trim() + " " + line.Substring(83, 9).Trim();
                                    break;
                                case 'I':
                                    itemCategory.ItemCategoryID = Convert.ToInt32(line.Substring(0, 5));
                                    itemStock.Quantity = Convert.ToInt32(line.Substring(5, 5));
                                    break;
                                case 'L':
                                    
                                    break;
                                case 'O':
                                    moreCustomerOrder = false;
                                    break;
                                default:
                                    throw new InvalidDataException();

                            }
                        }
                        else if (moreCustomerOrder && line.Substring(0, 2) == "HD")
                        {
                            counter = 1;
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
        private void ParseVendorOrderFile()
        {

        }
    }
}
