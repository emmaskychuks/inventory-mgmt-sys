namespace InventoryManagementSystem
{
    partial class CustomerScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerScreen));
            this.CustomerTabControl = new System.Windows.Forms.TabControl();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubmitOrderButton = new System.Windows.Forms.Button();
            this.drop_customer = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIS375_InventoryManagementDataSet = new InventoryManagementSystem.CIS375_InventoryManagementDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drop_item = new System.Windows.Forms.ComboBox();
            this.itemCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.itemCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockItemLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPerWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTabPage = new System.Windows.Forms.TabPage();
            this.existOrderPage = new System.Windows.Forms.Button();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCategoriesTableAdapter = new InventoryManagementSystem.CIS375_InventoryManagementDataSetTableAdapters.ItemCategoriesTableAdapter();
            this.ordersTableAdapter = new InventoryManagementSystem.CIS375_InventoryManagementDataSetTableAdapters.OrdersTableAdapter();
            this.cIS375_InventoryManagementDataSet1 = new InventoryManagementSystem.CIS375_InventoryManagementDataSet1();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new InventoryManagementSystem.CIS375_InventoryManagementDataSet1TableAdapters.OrdersTableAdapter();
            this.customersTableAdapter = new InventoryManagementSystem.CIS375_InventoryManagementDataSetTableAdapters.CustomersTableAdapter();
            this.dgv_orderedItems = new System.Windows.Forms.DataGridView();
            this.CustomernameLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ItemReturnQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnItemGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderSearchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerTabControl.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.OrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderedItems)).BeginInit();
            this.ReturnItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTabControl
            // 
            this.CustomerTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerTabControl.Controls.Add(this.ItemTabPage);
            this.CustomerTabControl.Controls.Add(this.OrderTabPage);
            this.CustomerTabControl.Location = new System.Drawing.Point(9, 0);
            this.CustomerTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerTabControl.Name = "CustomerTabControl";
            this.CustomerTabControl.SelectedIndex = 0;
            this.CustomerTabControl.Size = new System.Drawing.Size(1489, 652);
            this.CustomerTabControl.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Controls.Add(this.groupBox2);
            this.ItemTabPage.Controls.Add(this.groupBox1);
            this.ItemTabPage.Controls.Add(this.exit);
            this.ItemTabPage.Controls.Add(this.ItemGridView);
            this.ItemTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ItemTabPage.Size = new System.Drawing.Size(1481, 623);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "Item Page";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.SubmitOrderButton);
            this.groupBox2.Controls.Add(this.drop_customer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1095, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finish Order";
            // 
            // SubmitOrderButton
            // 
            this.SubmitOrderButton.Location = new System.Drawing.Point(98, 98);
            this.SubmitOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitOrderButton.Name = "SubmitOrderButton";
            this.SubmitOrderButton.Size = new System.Drawing.Size(162, 42);
            this.SubmitOrderButton.TabIndex = 7;
            this.SubmitOrderButton.Text = "Proceed To Checkout";
            this.SubmitOrderButton.UseVisualStyleBackColor = true;
            this.SubmitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // drop_customer
            // 
            this.drop_customer.DataSource = this.customersBindingSource;
            this.drop_customer.DisplayMember = "Name";
            this.drop_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_customer.FormattingEnabled = true;
            this.drop_customer.Location = new System.Drawing.Point(118, 45);
            this.drop_customer.Margin = new System.Windows.Forms.Padding(2);
            this.drop_customer.Name = "drop_customer";
            this.drop_customer.Size = new System.Drawing.Size(201, 24);
            this.drop_customer.TabIndex = 9;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.cIS375_InventoryManagementDataSet;
            // 
            // cIS375_InventoryManagementDataSet
            // 
            this.cIS375_InventoryManagementDataSet.DataSetName = "CIS375_InventoryManagementDataSet";
            this.cIS375_InventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customers";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.AddToCartButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.drop_item);
            this.groupBox1.Location = new System.Drawing.Point(1095, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy Items";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(99, 84);
            this.txt_quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(201, 22);
            this.txt_quantity.TabIndex = 10;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(119, 135);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(113, 44);
            this.AddToCartButton.TabIndex = 1;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // drop_item
            // 
            this.drop_item.DataSource = this.itemCategoriesBindingSource;
            this.drop_item.DisplayMember = "Name";
            this.drop_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_item.FormattingEnabled = true;
            this.drop_item.Location = new System.Drawing.Point(99, 42);
            this.drop_item.Margin = new System.Windows.Forms.Padding(2);
            this.drop_item.Name = "drop_item";
            this.drop_item.Size = new System.Drawing.Size(201, 24);
            this.drop_item.TabIndex = 5;
            // 
            // itemCategoriesBindingSource
            // 
            this.itemCategoriesBindingSource.DataMember = "ItemCategories";
            this.itemCategoriesBindingSource.DataSource = this.cIS375_InventoryManagementDataSet;
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.Location = new System.Drawing.Point(1326, 17);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 44);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            this.ItemGridView.AllowUserToOrderColumns = true;
            this.ItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemGridView.AutoGenerateColumns = false;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCategoryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.restockItemLimitDataGridViewTextBoxColumn,
            this.maxPerWarehouseDataGridViewTextBoxColumn,
            this.locationInWarehouseDataGridViewTextBoxColumn});
            this.ItemGridView.DataSource = this.itemCategoriesBindingSource;
            this.ItemGridView.Location = new System.Drawing.Point(4, 31);
            this.ItemGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowTemplate.Height = 33;
            this.ItemGridView.Size = new System.Drawing.Size(1077, 256);
            this.ItemGridView.TabIndex = 0;
            // 
            // itemCategoryIDDataGridViewTextBoxColumn
            // 
            this.itemCategoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.itemCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryID";
            this.itemCategoryIDDataGridViewTextBoxColumn.HeaderText = "ItemCategoryID";
            this.itemCategoryIDDataGridViewTextBoxColumn.Name = "itemCategoryIDDataGridViewTextBoxColumn";
            this.itemCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryIDDataGridViewTextBoxColumn.Width = 133;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restockItemLimitDataGridViewTextBoxColumn
            // 
            this.restockItemLimitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.restockItemLimitDataGridViewTextBoxColumn.DataPropertyName = "RestockItemLimit";
            this.restockItemLimitDataGridViewTextBoxColumn.HeaderText = "RestockItemLimit";
            this.restockItemLimitDataGridViewTextBoxColumn.Name = "restockItemLimitDataGridViewTextBoxColumn";
            this.restockItemLimitDataGridViewTextBoxColumn.ReadOnly = true;
            this.restockItemLimitDataGridViewTextBoxColumn.Visible = false;
            // 
            // maxPerWarehouseDataGridViewTextBoxColumn
            // 
            this.maxPerWarehouseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxPerWarehouseDataGridViewTextBoxColumn.DataPropertyName = "MaxPerWarehouse";
            this.maxPerWarehouseDataGridViewTextBoxColumn.HeaderText = "MaxPerWarehouse";
            this.maxPerWarehouseDataGridViewTextBoxColumn.Name = "maxPerWarehouseDataGridViewTextBoxColumn";
            this.maxPerWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxPerWarehouseDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationInWarehouseDataGridViewTextBoxColumn
            // 
            this.locationInWarehouseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationInWarehouseDataGridViewTextBoxColumn.DataPropertyName = "LocationInWarehouse";
            this.locationInWarehouseDataGridViewTextBoxColumn.HeaderText = "LocationInWarehouse";
            this.locationInWarehouseDataGridViewTextBoxColumn.Name = "locationInWarehouseDataGridViewTextBoxColumn";
            this.locationInWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationInWarehouseDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrderTabPage
            // 
            this.OrderTabPage.Controls.Add(this.label6);
            this.OrderTabPage.Controls.Add(this.dgv_orderedItems);
            this.OrderTabPage.Controls.Add(this.existOrderPage);
            this.OrderTabPage.Controls.Add(this.OrderSearchButton);
            this.OrderTabPage.Controls.Add(this.ReturnItemGroupBox);
            this.OrderTabPage.Controls.Add(this.CustomerNameTextBox);
            this.OrderTabPage.Controls.Add(this.CustomernameLabel);
            this.OrderTabPage.Controls.Add(this.OrderGridView);
            this.OrderTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrderTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.OrderTabPage.Name = "OrderTabPage";
            this.OrderTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.OrderTabPage.Size = new System.Drawing.Size(1481, 623);
            this.OrderTabPage.TabIndex = 1;
            this.OrderTabPage.Text = "Order Page";
            this.OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // existOrderPage
            // 
            this.existOrderPage.Location = new System.Drawing.Point(1362, 15);
            this.existOrderPage.Margin = new System.Windows.Forms.Padding(2);
            this.existOrderPage.Name = "existOrderPage";
            this.existOrderPage.Size = new System.Drawing.Size(98, 28);
            this.existOrderPage.TabIndex = 6;
            this.existOrderPage.Text = "Exit";
            this.existOrderPage.UseVisualStyleBackColor = true;
            this.existOrderPage.Click += new System.EventHandler(this.existOrderPage_Click);
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.AllowUserToOrderColumns = true;
            this.OrderGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.OrderCode,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.customerCustomerIDDataGridViewTextBoxColumn});
            this.OrderGridView.DataSource = this.ordersBindingSource;
            this.OrderGridView.Location = new System.Drawing.Point(468, 15);
            this.OrderGridView.Margin = new System.Windows.Forms.Padding(2);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowTemplate.Height = 33;
            this.OrderGridView.Size = new System.Drawing.Size(890, 236);
            this.OrderGridView.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderCode
            // 
            this.OrderCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderCode.DataPropertyName = "OrderCode";
            this.OrderCode.HeaderText = "OrderCode";
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.ReadOnly = true;
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            this.dateOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCustomerIDDataGridViewTextBoxColumn
            // 
            this.customerCustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.customerCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_CustomerID";
            this.customerCustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_CustomerID";
            this.customerCustomerIDDataGridViewTextBoxColumn.Name = "customerCustomerIDDataGridViewTextBoxColumn";
            this.customerCustomerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCustomerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.cIS375_InventoryManagementDataSet;
            // 
            // itemCategoriesTableAdapter
            // 
            this.itemCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // cIS375_InventoryManagementDataSet1
            // 
            this.cIS375_InventoryManagementDataSet1.DataSetName = "CIS375_InventoryManagementDataSet1";
            this.cIS375_InventoryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.cIS375_InventoryManagementDataSet1;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_orderedItems
            // 
            this.dgv_orderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderedItems.Location = new System.Drawing.Point(468, 282);
            this.dgv_orderedItems.Name = "dgv_orderedItems";
            this.dgv_orderedItems.RowTemplate.Height = 24;
            this.dgv_orderedItems.Size = new System.Drawing.Size(889, 259);
            this.dgv_orderedItems.TabIndex = 13;
            // 
            // CustomernameLabel
            // 
            this.CustomernameLabel.AutoSize = true;
            this.CustomernameLabel.Location = new System.Drawing.Point(107, 100);
            this.CustomernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomernameLabel.Name = "CustomernameLabel";
            this.CustomernameLabel.Size = new System.Drawing.Size(109, 17);
            this.CustomernameLabel.TabIndex = 2;
            this.CustomernameLabel.Text = "Customer Name";
            this.CustomernameLabel.Click += new System.EventHandler(this.CustomernameLabel_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(51, 125);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(235, 22);
            this.CustomerNameTextBox.TabIndex = 3;
            this.CustomerNameTextBox.WordWrap = false;
            this.CustomerNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.itemCategoriesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // ItemReturnQuantityTextBox
            // 
            this.ItemReturnQuantityTextBox.Location = new System.Drawing.Point(177, 101);
            this.ItemReturnQuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemReturnQuantityTextBox.Multiline = true;
            this.ItemReturnQuantityTextBox.Name = "ItemReturnQuantityTextBox";
            this.ItemReturnQuantityTextBox.Size = new System.Drawing.Size(133, 33);
            this.ItemReturnQuantityTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // ReturnItemGroupBox
            // 
            this.ReturnItemGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnItemGroupBox.Controls.Add(this.label4);
            this.ReturnItemGroupBox.Controls.Add(this.ItemReturnQuantityTextBox);
            this.ReturnItemGroupBox.Controls.Add(this.comboBox1);
            this.ReturnItemGroupBox.Controls.Add(this.button1);
            this.ReturnItemGroupBox.Controls.Add(this.label1);
            this.ReturnItemGroupBox.Location = new System.Drawing.Point(18, 221);
            this.ReturnItemGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnItemGroupBox.Name = "ReturnItemGroupBox";
            this.ReturnItemGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ReturnItemGroupBox.Size = new System.Drawing.Size(422, 243);
            this.ReturnItemGroupBox.TabIndex = 4;
            this.ReturnItemGroupBox.TabStop = false;
            this.ReturnItemGroupBox.Text = "Return Item";
            this.ReturnItemGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // OrderSearchButton
            // 
            this.OrderSearchButton.Location = new System.Drawing.Point(299, 130);
            this.OrderSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderSearchButton.Name = "OrderSearchButton";
            this.OrderSearchButton.Size = new System.Drawing.Size(95, 28);
            this.OrderSearchButton.TabIndex = 5;
            this.OrderSearchButton.Text = "Search";
            this.OrderSearchButton.UseVisualStyleBackColor = true;
            this.OrderSearchButton.Click += new System.EventHandler(this.OrderSearchButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "Please look up a customer to see their current and historical orders";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1500, 653);
            this.Controls.Add(this.CustomerTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Customer Screen";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            this.CustomerTabControl.ResumeLayout(false);
            this.ItemTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.OrderTabPage.ResumeLayout(false);
            this.OrderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderedItems)).EndInit();
            this.ReturnItemGroupBox.ResumeLayout(false);
            this.ReturnItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CustomerTabControl;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.TabPage OrderTabPage;
        private System.Windows.Forms.DataGridView ItemGridView;
        private CIS375_InventoryManagementDataSet cIS375_InventoryManagementDataSet;
        private System.Windows.Forms.BindingSource itemCategoriesBindingSource;
        private CIS375_InventoryManagementDataSetTableAdapters.ItemCategoriesTableAdapter itemCategoriesTableAdapter;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CIS375_InventoryManagementDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedFromWarehouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backOrderOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ComboBox drop_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CIS375_InventoryManagementDataSet1 cIS375_InventoryManagementDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private CIS375_InventoryManagementDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restockItemLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPerWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationInWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button SubmitOrderButton;
        private System.Windows.Forms.Button existOrderPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCustomerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox drop_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CIS375_InventoryManagementDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_orderedItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OrderSearchButton;
        private System.Windows.Forms.GroupBox ReturnItemGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemReturnQuantityTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomernameLabel;
    }
}