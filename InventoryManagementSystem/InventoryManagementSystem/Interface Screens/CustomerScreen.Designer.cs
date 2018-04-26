namespace InventoryManagementSystem.Interface_Screens
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
            this.CustomerTabControl = new System.Windows.Forms.TabControl();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.OrderTabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerTabControl.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTabControl
            // 
            this.CustomerTabControl.Controls.Add(this.ItemTabPage);
            this.CustomerTabControl.Controls.Add(this.OrderTabPage);
            this.CustomerTabControl.Location = new System.Drawing.Point(12, 12);
            this.CustomerTabControl.Name = "CustomerTabControl";
            this.CustomerTabControl.SelectedIndex = 0;
            this.CustomerTabControl.Size = new System.Drawing.Size(1134, 1125);
            this.CustomerTabControl.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Controls.Add(this.label1);
            this.ItemTabPage.Controls.Add(this.textBox1);
            this.ItemTabPage.Location = new System.Drawing.Point(8, 39);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(1118, 1078);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "Item Page";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // OrderTabPage
            // 
            this.OrderTabPage.Location = new System.Drawing.Point(8, 39);
            this.OrderTabPage.Name = "OrderTabPage";
            this.OrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTabPage.Size = new System.Drawing.Size(1118, 1078);
            this.OrderTabPage.TabIndex = 1;
            this.OrderTabPage.Text = "Order Page";
            this.OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 994);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 1149);
            this.Controls.Add(this.CustomerTabControl);
            this.Name = "CustomerScreen";
            this.Text = "Customer Screen";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            this.CustomerTabControl.ResumeLayout(false);
            this.ItemTabPage.ResumeLayout(false);
            this.ItemTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CustomerTabControl;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.TabPage OrderTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}