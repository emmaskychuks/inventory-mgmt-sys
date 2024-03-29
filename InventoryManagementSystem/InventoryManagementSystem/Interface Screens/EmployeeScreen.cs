﻿using InventoryClasses;
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
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet1.ItemStocks' table. You can move, or remove it, as needed.
            this.itemStocksTableAdapter.Fill(this.cIS375_InventoryManagementDataSet1.ItemStocks);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Warehouses);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.ItemCategories' table. You can move, or remove it, as needed.
            this.itemCategoriesTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.ItemCategories);
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.cIS375_InventoryManagementDataSet.Vendors);
        }
        private void updateAllDatatable()
        {
            //using (InvContext context = new InvContext())
            //{
            //    var query = context.ItemCategories.
            //        Include(x => x.Standard).
            //        Select(x => new ItemCategory
            //        {
            //            ItemCategoryID = x.ItemCategoryID,
            //            Name = x.Name,
            //            Price = x.Price,
            //            Description = x.Description,
            //            RestockItemLimit = x.RestockItemLimit,
            //            MaxPerWarehouse = x.MaxPerWarehouse,
            //            LocationInWarehouse = x.LocationInWarehouse
            //        });

            //    WarehouseItemDataGridView.DataSource = query.ToList();
            //}
            // TODO: This line of code loads data into the 'cIS375_InventoryManagementDataSet1.ItemStocks' table. You can move, or remove it, as needed.
            this.itemStocksTableAdapter.Fill(this.cIS375_InventoryManagementDataSet1.ItemStocks);
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

        private void DeleteVendorButton_Click(object sender, EventArgs e)
        {
            int result = Vendor.DeleteVendor(Convert.ToInt32(VendorIDText.Text));

            if(result == 1)
                MessageBox.Show("Vendor doesn't exist");
            else if(result == 2)
                MessageBox.Show("Vendor cannot be deleted. Vendor has items in the inventory");

            updateAllDatatable();
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            string nameOfVendorToAdd = VendorNameTextBox.Text;
            string nameOfItem = VendorItemComboBox.GetItemText(this.VendorItemComboBox.SelectedItem);
            bool result = Vendor.AddVendor(nameOfVendorToAdd, nameOfItem);

            if(!result)
                MessageBox.Show("Item specified already exists");

            updateAllDatatable();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ItemCategory.AddItem(ItemName.Text, ItemDescription.Text, ItemPrice.Text, 0);
            updateAllDatatable();
        }

        private void exitEmployeeScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscontinueItemButton_Click(object sender, EventArgs e)
        {
            bool result = ItemCategory.DeleteItem(WarehouseItemComboBox.GetItemText(WarehouseItemComboBox.SelectedItem));
            updateAllDatatable();
        }
    }
}
