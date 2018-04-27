using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryClasses.Entities;
using InventoryClasses;
using System.Data.Entity;

namespace InventoryManagementSystem
{
    public partial class CustomerScreen : Form
    {

        private Order ShoppingCartOrder = new Order()
        {

        };

        private class otherbinding
        {
            public int OrderNumber;
            public string Item;
            public int Quantity;
            public float Price;
        }
        private class DataBindingProjection
        {
            //For Order
            public int OrderID { get; set; }
            public string OrderCode { get; set; }
            public DateTime DateOrdered { get; set; }
        }
        
        public CustomerScreen()
        {
            InitializeComponent();
        }

        private List<ItemCategory> ItemCategories = new List<ItemCategory>();
        private List<Customer> Customers = new List<Customer>();

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Customers);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Orders);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.ItemCategories' table. You can move, or remove it, as needed.
            // this.itemCategoriesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.ItemCategories);

            using (InvContext ctx = new InvContext())
            {
                ItemCategories = ctx.ItemCategories.ToList();
                Customers = ctx.Customers.ToList();
            }

            this.drop_item.DataSource = ItemCategories;
            this.drop_item.DisplayMember = "Name";
            this.drop_item.ValueMember = null; // keeps the object as the value member

            this.drop_customer.DataSource = Customers;
            this.drop_customer.DisplayMember = "Name";
            this.drop_customer.ValueMember = null; // keeps the object as the value member

            
            // Order tab functionality
            OrderGridView.Visible = false;
            dgv_orderedItems.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //This button is used to exit current window
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void existOrderPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Order> customersOrders = new List<Order>();
        private List<OrderedItems> custoemrOrderedItems = new List<OrderedItems>();

        private void OrderSearchButton_Click(object sender, EventArgs e)
        {
            using (InvContext context = new InvContext())
            {

                Customer searchedCustomer = context.Customers.FirstOrDefault(x => x.Name.ToLower() == CustomerNameTextBox.Text.ToLower());


                if (searchedCustomer == null)
                {
                    MessageBox.Show("Sorry, that customer could not be found");
                    OrderGridView.Visible = false;
                    dgv_orderedItems.Visible = false;
                    return;
                }

                customersOrders = context.Orders.Where(x => x.Customer.CustomerID == searchedCustomer.CustomerID)
                    .Include(x=>x.ItemsOrdered)
                    .Include(x => x.ItemsOrdered.Select(y=>y.Item))
                    .ToList();

                if (customersOrders.Count > 0)
                {
                    OrderGridView.Visible = true;
                    dgv_orderedItems.Visible = true;

                    var query = customersOrders.Select(
                        x => new DataBindingProjection
                        {
                            OrderID = x.OrderID,
                            OrderCode = x.OrderCode,
                            DateOrdered = x.DateOrdered,
                        });

                    OrderGridView.DataSource = query.ToList();


                    dgv_orderedItems.DataSource = customersOrders.Select(
                        x => x.ItemsOrdered.Select(
                            o => new otherbinding
                            {
                                OrderNumber = o.Order.OrderID,
                                Item = o.Item.Name,
                                Quantity = o.Quantity,
                                Price = ((float)o.Item.Price * (float)o.Quantity),
                            }
                        )).ToList();

                }
                else
                {
                    MessageBox.Show("Error: Customer has no order history");
                    OrderGridView.Visible = false;
                    dgv_orderedItems.Visible = false;
                }
                    
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            //int itemID = (int) drop_item.;
            ItemCategory selectedItem = drop_item.SelectedValue as ItemCategory;
            
            int quantity = (int)txt_quantity.Value;

            if (selectedItem != null && quantity != 0)
            {
                drop_item.SelectedIndex = 0;
                txt_quantity.Value = 0;

                bool success = ShoppingCartOrder.AddItemToOrder(selectedItem, quantity);
                if (!success)
                    MessageBox.Show("Error: Sorry, there was a problem adding an item to the cart");
                else
                    MessageBox.Show($"Added x{quantity} {selectedItem.Name}(s) to the cart!");
            }
            else
            {
                MessageBox.Show("Error: Please fill out the order completely before adding it to the cart.");
                return;
            }

            
        }

        private void CustomernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            Customer customer = drop_customer.SelectedValue as Customer;
            
            if (customer == null)
            {
                MessageBox.Show("Error: Please have a customer selected to receive the Order.");
                drop_customer.SelectedIndex = 0;
                return;
            }

            // finish setting up the order then submit
            ShoppingCartOrder.Customer = customer;
            bool submittedSuccessfully = ShoppingCartOrder.Submit();
            
            if (submittedSuccessfully)
            {
                MessageBox.Show("Order submitted successfully");
                ShoppingCartOrder = new Order();
            }
            else
            {
                MessageBox.Show("Error: Sorry, there was a problem with submitting the order for processing.");
            }

            drop_customer.SelectedIndex = 0;
        }

        private void CustomerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OrderSearchButton.PerformClick();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
