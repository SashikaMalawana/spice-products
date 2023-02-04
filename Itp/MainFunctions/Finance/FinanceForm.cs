using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;


namespace Itp.MainFunctions.Finance
{
    public partial class FinanceForm : Form
    {
        //private object EmployeeManagement;

        public FinanceForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            salesManagement salesSubform = new salesManagement();
            salesSubform.TopLevel = false;
            panel1.Controls.Add(salesSubform);
            salesSubform.FormBorderStyle = FormBorderStyle.None;
            salesSubform.Dock = DockStyle.Fill;
            salesSubform.Show();

            

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();
            InventoryManagement inventorySubform = new InventoryManagement();
            inventorySubform.TopLevel = false;
            panel1.Controls.Add(inventorySubform);
            inventorySubform.FormBorderStyle = FormBorderStyle.None;
            inventorySubform.Dock = DockStyle.Fill;
            inventorySubform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     

            //employeeSubform.TopLevel = false;
            //panel1.Controls.Add(employeeSubform);
            //employeeSubform.FormBorderStyle = FormBorderStyle.None;
            //employeeSubform.Dock = DockStyle.Fill;
            //employeeSubform.Show();
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel1.Controls.Clear();
            MaintenanceManagement maintenanceSubform = new MaintenanceManagement();
            maintenanceSubform.TopLevel = false;
            panel1.Controls.Add(maintenanceSubform);
            maintenanceSubform.FormBorderStyle = FormBorderStyle.None;
            maintenanceSubform.Dock = DockStyle.Fill;
            maintenanceSubform.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel1.Controls.Clear();
            DeliveryManagement deliverySubform = new DeliveryManagement();
            deliverySubform.TopLevel = false;
            panel1.Controls.Add(deliverySubform);
            deliverySubform.FormBorderStyle = FormBorderStyle.None;
            deliverySubform.Dock = DockStyle.Fill;
            deliverySubform.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
