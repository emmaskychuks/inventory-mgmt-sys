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
            this.CustomerTabControl = new System.Windows.Forms.TabControl();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.itemCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIS375_InventoryManagementDataSet = new InventoryManagementSystem.CIS375_InventoryManagementDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.itemCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockItemLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPerWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTabPage = new System.Windows.Forms.TabPage();
            this.OrderSearchButton = new System.Windows.Forms.Button();
            this.ReturnItemGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemReturnQuantityTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomernameLabel = new System.Windows.Forms.Label();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemCategoriesTableAdapter = new InventoryManagementSystem.CIS375_InventoryManagementDataSetTableAdapters.ItemCategoriesTableAdapter();
            this.ordersTableAdapter = new InventoryManagementSystem.CIS375_InventoryManagementDataSetTableAdapters.OrdersTableAdapter();
            this.cIS375_InventoryManagementDataSet1 = new InventoryManagementSystem.CIS375_InventoryManagementDataSet1();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new InventoryManagementSystem.CIS375_InventoryManagementDataSet1TableAdapters.OrdersTableAdapter();
            this.CustomerTabControl.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.OrderTabPage.SuspendLayout();
            this.ReturnItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerTabControl
            // 
            this.CustomerTabControl.Controls.Add(this.ItemTabPage);
            this.CustomerTabControl.Controls.Add(this.OrderTabPage);
            this.CustomerTabControl.Location = new System.Drawing.Point(13, 0);
            this.CustomerTabControl.Name = "CustomerTabControl";
            this.CustomerTabControl.SelectedIndex = 0;
            this.CustomerTabControl.Size = new System.Drawing.Size(2226, 1393);
            this.CustomerTabControl.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Controls.Add(this.comboBox2);
            this.ItemTabPage.Controls.Add(this.label3);
            this.ItemTabPage.Controls.Add(this.label2);
            this.ItemTabPage.Controls.Add(this.textBox1);
            this.ItemTabPage.Controls.Add(this.PlaceOrderButton);
            this.ItemTabPage.Controls.Add(this.ItemGridView);
            this.ItemTabPage.Location = new System.Drawing.Point(8, 39);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(2210, 1346);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "Item Page";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.itemCategoriesBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1826, 633);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 33);
            this.comboBox2.TabIndex = 5;
            // 
            // itemCategoriesBindingSource
            // 
            this.itemCategoriesBindingSource.DataMember = "ItemCategories";
            this.itemCategoriesBindingSource.DataSource = this.cIS375_InventoryManagementDataSet;
            // 
            // cIS375_InventoryManagementDataSet
            // 
            this.cIS375_InventoryManagementDataSet.DataSetName = "CIS375_InventoryManagementDataSet";
            this.cIS375_InventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1708, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1708, 835);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1872, 820);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 59);
            this.textBox1.TabIndex = 2;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(1854, 934);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(169, 69);
            this.PlaceOrderButton.TabIndex = 1;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            this.ItemGridView.AllowUserToOrderColumns = true;
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
            this.ItemGridView.Location = new System.Drawing.Point(6, 79);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowTemplate.Height = 33;
            this.ItemGridView.Size = new System.Drawing.Size(1605, 1158);
            this.ItemGridView.TabIndex = 0;
            // 
            // itemCategoryIDDataGridViewTextBoxColumn
            // 
            this.itemCategoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.itemCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryID";
            this.itemCategoryIDDataGridViewTextBoxColumn.HeaderText = "ItemCategoryID";
            this.itemCategoryIDDataGridViewTextBoxColumn.Name = "itemCategoryIDDataGridViewTextBoxColumn";
            this.itemCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryIDDataGridViewTextBoxColumn.Width = 204;
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
            this.OrderTabPage.Controls.Add(this.OrderSearchButton);
            this.OrderTabPage.Controls.Add(this.ReturnItemGroupBox);
            this.OrderTabPage.Controls.Add(this.CustomerNameTextBox);
            this.OrderTabPage.Controls.Add(this.CustomernameLabel);
            this.OrderTabPage.Controls.Add(this.OrderGridView);
            this.OrderTabPage.Location = new System.Drawing.Point(8, 39);
            this.OrderTabPage.Name = "OrderTabPage";
            this.OrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTabPage.Size = new System.Drawing.Size(2210, 1346);
            this.OrderTabPage.TabIndex = 1;
            this.OrderTabPage.Text = "Order Page";
            this.OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // OrderSearchButton
            // 
            this.OrderSearchButton.Location = new System.Drawing.Point(1720, 403);
            this.OrderSearchButton.Name = "OrderSearchButton";
            this.OrderSearchButton.Size = new System.Drawing.Size(143, 43);
            this.OrderSearchButton.TabIndex = 5;
            this.OrderSearchButton.Text = "Search";
            this.OrderSearchButton.UseVisualStyleBackColor = true;
            // 
            // ReturnItemGroupBox
            // 
            this.ReturnItemGroupBox.Controls.Add(this.ItemReturnQuantityTextBox);
            this.ReturnItemGroupBox.Controls.Add(this.comboBox1);
            this.ReturnItemGroupBox.Controls.Add(this.button1);
            this.ReturnItemGroupBox.Controls.Add(this.label1);
            this.ReturnItemGroupBox.Location = new System.Drawing.Point(1436, 523);
            this.ReturnItemGroupBox.Name = "ReturnItemGroupBox";
            this.ReturnItemGroupBox.Size = new System.Drawing.Size(730, 702);
            this.ReturnItemGroupBox.TabIndex = 4;
            this.ReturnItemGroupBox.TabStop = false;
            this.ReturnItemGroupBox.Text = "Return Item";
            this.ReturnItemGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ItemReturnQuantityTextBox
            // 
            this.ItemReturnQuantityTextBox.Location = new System.Drawing.Point(268, 351);
            this.ItemReturnQuantityTextBox.Multiline = true;
            this.ItemReturnQuantityTextBox.Name = "ItemReturnQuantityTextBox";
            this.ItemReturnQuantityTextBox.Size = new System.Drawing.Size(197, 50);
            this.ItemReturnQuantityTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.itemCategoriesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(1630, 309);
            this.CustomerNameTextBox.Multiline = true;
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(350, 50);
            this.CustomerNameTextBox.TabIndex = 3;
            // 
            // CustomernameLabel
            // 
            this.CustomernameLabel.AutoSize = true;
            this.CustomernameLabel.Location = new System.Drawing.Point(1715, 270);
            this.CustomernameLabel.Name = "CustomernameLabel";
            this.CustomernameLabel.Size = new System.Drawing.Size(166, 25);
            this.CustomernameLabel.TabIndex = 2;
            this.CustomernameLabel.Text = "Customer Name";
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToOrderColumns = true;
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.customerCustomerIDDataGridViewTextBoxColumn});
            this.OrderGridView.DataSource = this.ordersBindingSource;
            this.OrderGridView.Location = new System.Drawing.Point(6, 67);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowTemplate.Height = 33;
            this.OrderGridView.Size = new System.Drawing.Size(1335, 1158);
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
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            // 
            // customerCustomerIDDataGridViewTextBoxColumn
            // 
            this.customerCustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.customerCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_CustomerID";
            this.customerCustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_CustomerID";
            this.customerCustomerIDDataGridViewTextBoxColumn.Name = "customerCustomerIDDataGridViewTextBoxColumn";
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
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2251, 1405);
            this.Controls.Add(this.CustomerTabControl);
            this.MaximizeBox = false;
            this.Name = "CustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Customer Screen";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            this.CustomerTabControl.ResumeLayout(false);
            this.ItemTabPage.ResumeLayout(false);
            this.ItemTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.OrderTabPage.ResumeLayout(false);
            this.OrderTabPage.PerformLayout();
            this.ReturnItemGroupBox.ResumeLayout(false);
            this.ReturnItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS375_InventoryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCustomerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedFromWarehouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backOrderOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomernameLabel;
        private System.Windows.Forms.GroupBox ReturnItemGroupBox;
        private System.Windows.Forms.Button OrderSearchButton;
        private System.Windows.Forms.TextBox ItemReturnQuantityTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}