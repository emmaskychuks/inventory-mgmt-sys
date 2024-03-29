﻿namespace InventoryManagementSystem
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.CustomerButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ActiveHoursCheckBox = new System.Windows.Forms.CheckBox();
            this.UnActiveHoursButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(246, 747);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(245, 101);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(246, 588);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(245, 101);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ActiveHoursCheckBox
            // 
            this.ActiveHoursCheckBox.AutoSize = true;
            this.ActiveHoursCheckBox.Location = new System.Drawing.Point(571, 747);
            this.ActiveHoursCheckBox.Name = "ActiveHoursCheckBox";
            this.ActiveHoursCheckBox.Size = new System.Drawing.Size(166, 29);
            this.ActiveHoursCheckBox.TabIndex = 3;
            this.ActiveHoursCheckBox.Text = "Active Hours";
            this.ActiveHoursCheckBox.UseVisualStyleBackColor = true;
            this.ActiveHoursCheckBox.CheckedChanged += new System.EventHandler(this.ActiveHoursCheckBox_CheckedChanged);
            // 
            // UnActiveHoursButton
            // 
            this.UnActiveHoursButton.AutoSize = true;
            this.UnActiveHoursButton.Location = new System.Drawing.Point(571, 819);
            this.UnActiveHoursButton.Name = "UnActiveHoursButton";
            this.UnActiveHoursButton.Size = new System.Drawing.Size(191, 29);
            this.UnActiveHoursButton.TabIndex = 4;
            this.UnActiveHoursButton.Text = "Unactive Hours";
            this.UnActiveHoursButton.UseVisualStyleBackColor = true;
            this.UnActiveHoursButton.CheckedChanged += new System.EventHandler(this.UnActiveHoursButton_CheckedChanged);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 870);
            this.Controls.Add(this.UnActiveHoursButton);
            this.Controls.Add(this.ActiveHoursCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.CustomerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management App";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ActiveHoursCheckBox;
        private System.Windows.Forms.CheckBox UnActiveHoursButton;
    }
}

