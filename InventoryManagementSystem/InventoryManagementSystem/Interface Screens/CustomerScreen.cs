using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
        {
            InitializeComponent();
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Orders);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.ItemCategories' table. You can move, or remove it, as needed.
            this.itemCategoriesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.ItemCategories);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //This button is used to exit current window
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void existOrderPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
