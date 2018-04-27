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

namespace InventoryManagementSystem
{
    public partial class CustomerScreen : Form
    {
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

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Customers);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Orders);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.ItemCategories' table. You can move, or remove it, as needed.
            this.itemCategoriesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.ItemCategories);

            OrderGridView.Visible = false;

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

        private void OrderSearchButton_Click(object sender, EventArgs e)
        {
            using (InvContext context = new InvContext())
            {
                if (context.Orders.Any(x => x.Customer.Name == CustomerNameTextBox.Text))
                {
                    OrderGridView.Visible = true;
                    var query = context.Orders.
                        Where(x => x.Customer.Name == CustomerNameTextBox.Text).
                        Select(x => new DataBindingProjection
                        {
                            OrderID = x.OrderID,
                            OrderCode = x.OrderCode,
                            DateOrdered = x.DateOrdered,
                        });

                    OrderGridView.DataSource = query.ToList();
                }
                else
                    MessageBox.Show("Customer doesn't exist");
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
