using InventoryClasses;
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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
        {
            InitializeComponent();
        }

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Warehouses);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.ItemCategories' table. You can move, or remove it, as needed.
            this.itemCategoriesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.ItemCategories);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Vendors);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void VendorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteVendorButton_Click(object sender, EventArgs e)
        {
            string vendorID = VendorIDText.Text;
            InvContext context = new InvContext();
            var vendor = (Vendor) context.Vendors.Where(x => x.VendorID == Convert.ToInt32(vendorID)).Where(x => x.ItemProvided != null);

            if(vendor == null)
            {
                //Delte Vendor
                context.Vendors.Remove(vendor);
            }
            else
            {
                MessageBox.Show("Vendor cannot be deleted. Vendor has items in the inventory");
            }
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            InvContext context = new InvContext();
            string nameOfVendorToAdd = VendorNameTextBox.Text;
            string nameOfItem = VendorItemComboBox.GetItemText(this.VendorItemComboBox.SelectedItem);
            ItemCategory itemCategory = (ItemCategory)context.ItemCategories.Where(x => x.Name == nameOfItem); 

            Vendor vendor
        }
    }
}
