using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryClasses;

namespace InventoryManagementSystem
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            if(UnActiveHoursButton.Checked)
            {
                CustomerButton.Enabled = false;
                EmployeeButton.Enabled = false;
            }
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            new CustomerScreen().ShowDialog();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            new EmployeeScreen().ShowDialog();
        }

        private static void StartBatchFileProcess()
        {
            string vendorShipmentFileName = "VendorShipment.txt";
            string customerOrderFileName = "CustomOrder.txt";

            string vendorFilePath = Path.Combine(Environment.CurrentDirectory, @"Batch Files\", vendorShipmentFileName);
            string customerFilePath = Path.Combine(Environment.CurrentDirectory, @"Batch Files\", customerOrderFileName);

            BatchFileProcessor.ProcessFile("VendorShipment", vendorFilePath);
        }

        private void ActiveHoursCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveHoursCheckBox.Checked)
            {
                UnActiveHoursButton.CheckState = CheckState.Unchecked;
                CustomerButton.Enabled = true;
                EmployeeButton.Enabled = true;
            }
        }

        private void UnActiveHoursButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UnActiveHoursButton.Checked)
            {
                ActiveHoursCheckBox.CheckState = CheckState.Unchecked;
                CustomerButton.Enabled = false;
                EmployeeButton.Enabled = false;
            }
        }
    }
}
